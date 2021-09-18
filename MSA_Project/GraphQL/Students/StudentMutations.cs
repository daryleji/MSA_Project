using HotChocolate;
using HotChocolate.Types;
using MSA_Project.Data;
using MSA_Project.Extensions;
using MSA_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MSA_Project.GraphQL.Students
{
    [ExtendObjectType(name: "Mutation")]
    public class StudentMutations
    {
        [UseAppDbContext]
        public async Task<Student> AddStudentAsync(AddStudentInput input, [ScopedService] AppDbContext context, CancellationToken cancellationToken)
        {
            var student = new Student
            {
                Name = input.Name,
                GitHub = input.Github,
                ImageURI = input.ImageURI,
            };

            context.Students.Add(student);

            await context.SaveChangesAsync(cancellationToken);

            return student;
        }

        [UseAppDbContext]
        public async Task<Student> EditStudentAsync(EditStudentInput input, [ScopedService] AppDbContext context, CancellationToken cancellationToken)
        {
            var student = await context.Students.FindAsync(int.Parse(input.Id));

            student.Name = input.Name ?? student.Name;
            student.ImageURI = input.ImageURI ?? student.ImageURI;

            context.Students.Add(student);

            await context.SaveChangesAsync(cancellationToken);

            return student;
        }
    }
}
