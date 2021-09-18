namespace MSA_Project.GraphQL.Students
{
    public record EditStudentInput
    (
        string Id,
        string? Name,
        string? ImageURI
    );
}
