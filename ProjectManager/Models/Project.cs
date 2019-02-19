using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManager.Models
{
    public class Project
    {
        public Project()
        {
            this.Tasks = new HashSet<ProjectTask>();
        }
        public int Id { get; set; }

        public string ProjectTitle { get; set; }

        [Required]
        public string ProjectDetails { get; set; }
        
      
        public ApplicationUser User { get; set; }

        [Required]
        public string UserId { get; set; }
        [Required]
        public Status Status { get; set; }

        public ICollection<ProjectTask> Tasks { get; set; }
        public string DateTime { get; set; }

    }
}