using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectManager.Models
{
    public class UserTasks
    {
        public ProjectTask Task { get; set; }
        public ApplicationUser User { get; set; }

        [Key]
        [Column(Order = 1)]
        public int TaskId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(Order = 2)]
        public string UserId { get; set; }
    }
}