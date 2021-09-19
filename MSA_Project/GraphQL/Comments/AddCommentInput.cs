namespace MSA_Project.GraphQL.Comments
{
    public record AddCommentInput(
        string Content,
        string ProjectId);
}