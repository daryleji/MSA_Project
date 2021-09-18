using HotChocolate;
using HotChocolate.Types;
using MSA_Project.Data;
using MSA_Project.Extensions;
using MSA_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSA_Project.GraphQL.Projects
{
    [ExtendObjectType(name: "Query")]
    public class ProjectQueries
    {
        [UseAppDbContext]
        [UsePaging]
        public IQueryable<Project> GetProjects([ScopedService] AppDbContext context)
        {
            return context.Projects.OrderBy(prop => prop.Created);
        }

        [UseAppDbContext]
        public Project GetProject(int Id, [ScopedService] AppDbContext context)
        {
            return context.Projects.Find(Id);
        }
    }
}
