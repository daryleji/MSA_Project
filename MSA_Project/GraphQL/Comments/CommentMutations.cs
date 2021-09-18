using System;
using System.Threading;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Types;
using MSA_Project.Models;
using MSA_Project.Data;
using MSA_Project.Extensions;

namespace MSA_Project.GraphQL.Comments
{
    [ExtendObjectType(name: "Mutation")]
    public class CommentMutations
    {
        [UseAppDbContext]
        public async Task<Comment> AddCommentAsync(AddCommentInput input,
        [ScopedService] AppDbContext context, CancellationToken cancellationToken)
        {
            var comment = new Comment
            {
                Content = input.Content,
                ProjectId = int.Parse(input.ProjectId),
                StudentId = int.Parse(input.StudentId),
                Modified = DateTime.Now,
                Created = DateTime.Now,
            };
            context.Comments.Add(comment);

            await context.SaveChangesAsync(cancellationToken);

            return comment;
        }

        [UseAppDbContext]
        public async Task<Comment> EditCommentAsync(EditCommentInput input,
                [ScopedService] AppDbContext context, CancellationToken cancellationToken)
        {
            var comment = await context.Comments.FindAsync(int.Parse(input.CommentId));
            comment.Content = input.Content ?? comment.Content;

            await context.SaveChangesAsync(cancellationToken);

            return comment;
        }
    }
}