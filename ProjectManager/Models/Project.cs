using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManager.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string ProjectTitle { get; set; }

        [Required]
        public string ProjectDetails { get; set; }
        public string Task { get; set; }

        [Required]
        public string TaskHandler { get; set; }

        [Required]
        public ApplicationUser User { get; set; }
        [Required]
        public Status Status { get; set; }

    }
}