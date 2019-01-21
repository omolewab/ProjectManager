using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManager.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser User { get; set; }
        public string ProjectName { get; set; }

        [Required]
        public string ProjectDetails { get; set; }
        public string Task { get; set; }

        [Required]
        public string TaskHandler { get; set; }
        public Status Status { get; set; }

    }
}