using HotChocolate;
using HotChocolate.Types;
using MSA_Project.Data;
using MSA_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSA_Project.GraphQL.Students
{
    [ExtendObjectType(name: "Query")]
    public class StudentQueries
    {
        public IQueryable<Student> GetStudents([ScopedService] AppDbContext context)
        {
            return context.Students;
        }

    }
}
