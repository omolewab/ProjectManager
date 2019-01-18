using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Models
{
    public class Project
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDetails { get; set; }
        public string Task { get; set; }
        public string TaskHandler { get; set; }
        public Status Status { get; set; }

    }
}