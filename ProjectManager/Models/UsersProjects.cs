using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectManager.Models
{
    public class UsersProjects
    {
        public Project Project { get; set; } 
        public ApplicationUser User { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ProjectId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(Order = 2)]
        public string UserId { get; set; }
    }
}