using MSA_Project.Models;

namespace MSA_Project.GraphQL.Students
{
    public record LoginPayload(
        Student student,
        string jwt);
}