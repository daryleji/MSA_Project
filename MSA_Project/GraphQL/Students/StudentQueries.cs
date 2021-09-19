using System.Linq;
using HotChocolate;
using HotChocolate.Types;
using MSA_Project.Data;
using MSA_Project.Models;
using MSA_Project.Extensions;
using HotChocolate.AspNetCore.Authorization;
using System.Security.Claims;

namespace MSAYearbook.GraphQL.Students
{
    [ExtendObjectType(name: "Query")]
    public class StudentQueries
    {
        [UseAppDbContext]
        [UsePaging]
        public IQueryable<Student> GetStudents([ScopedService] AppDbContext context)
        {
            return context.Students;
        }

        [UseAppDbContext]
        public Student GetStudent(int id, [ScopedService] AppDbContext context)
        {
            return context.Students.Find(id);
        }

        [UseAppDbContext]
        [Authorize]
        public Student GetSelf(ClaimsPrincipal claimsPrincipal, [ScopedService] AppDbContext context)
        {
            var studentIdStr = claimsPrincipal.Claims.First(c => c.Type == "studentId").Value;

            return context.Students.Find(int.Parse(studentIdStr));
        }
    }
}