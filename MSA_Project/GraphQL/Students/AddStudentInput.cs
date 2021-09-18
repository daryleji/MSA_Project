namespace MSA_Project.GraphQL.Students
{
    public record AddStudentInput
    (
        string Name,
        string Github,
        string? ImageURI
    );
}
