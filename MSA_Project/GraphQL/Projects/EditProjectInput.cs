namespace MSA_Project.GraphQL.Projects
{
    public record EditProjectInput(
        string ProjectId,
        string? Name,
        string? Description,
        string? Link);
}