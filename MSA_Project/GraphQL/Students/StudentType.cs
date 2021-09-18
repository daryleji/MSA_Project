using HotChocolate;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using MSA_Project.Data;
using MSA_Project.GraphQL.Comments;
using MSA_Project.GraphQL.Projects;
using MSA_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MSA_Project.GraphQL.Students
{
    public class StudentType : ObjectType<Student>
    {
        protected override void Configure(IObjectTypeDescriptor<Student> descriptor)
        {
            descriptor.Field(s => s.Id).Type<NonNullType<IdType>>();

            descriptor.Field(s => s.Name).Type<NonNullType<StringType>>();

            descriptor.Field(s => s.GitHub).Type<NonNullType<StringType>>();

            descriptor.Field(s => s.ImageURI).Type<NonNullType<StringType>>();

            descriptor.Field(s => s.Projects)
                .ResolveWith<Resolver>(r => r.GetProjects(default!, default!, default))
                .UseDbContext<AppDbContext>()
                .Type<NonNullType<ListType<NonNullType<ProjectType>>>>();

            descriptor.Field(s => s.Comments)
                .ResolveWith<Resolver>(r => r.GetComments(default!, default!, default))
                .UseDbContext<AppDbContext>()
                .Type<NonNullType<ListType<NonNullType<CommentType>>>>();

        }

        private class Resolver
        {
            public async Task<IEnumerable<Project>> GetProjects(Student student, [ScopedService] AppDbContext context, 
                CancellationToken cancellationToken)
            {
                return await context.Projects.Where(p => p.StudentId == student.Id).ToArrayAsync(cancellationToken);
            }

            public async Task<IEnumerable<Comment>> GetComments(Student student, [ScopedService] AppDbContext context,
                CancellationToken cancellationToken)
            {
                return await context.Comments.Where(c => c.StudentId == student.Id).ToArrayAsync(cancellationToken);
            }


        }
    }
}
