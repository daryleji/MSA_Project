using System.Linq;
using HotChocolate;
using HotChocolate.Types;
using MSA_Project.Data;
using MSA_Project.Models;
using MSA_Project.Extensions;

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
    }
}