using Microsoft.EntityFrameworkCore;
using MSA_Project.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSA_Project.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Student> Students { get; set; }


    }
}
