namespace MSA_Project.GraphQL.Comments
{
    public record EditCommentInput(
        string CommentId,
        string? Content);
}