using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSA_Project.Models
{
    public enum Year
    {
        YEAR_2021
    }


    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Link { get; set; }

        [Required]
        public int StudentId { get; set; }

        public Year Year { get; set; }

        public Student Student { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public DateTime Modified { get; set; }

        public DateTime Created { get; set; }
    }
}
