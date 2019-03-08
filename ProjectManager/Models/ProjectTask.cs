using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectManager.Models
{
    public class ProjectTask
    {
        public ProjectTask()
        {
            this.Users = new HashSet<ApplicationUser>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TaskTitle { get; set; }
        public string TaskHandler { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }

    }
}