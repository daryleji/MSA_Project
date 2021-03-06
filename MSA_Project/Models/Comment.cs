using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSA_Project.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        [Required]
        public int StudentId { get; set; }

        public Student Student { get; set; }

        [Required]
        public int ProjectId { get; set; }

        public Project Project { get; set; }

        public DateTime Modified { get; set; }

        public DateTime Created { get; set; }
    }
}
