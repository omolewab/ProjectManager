using ProjectManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.ViewModels
{
    public class CreateFormViewModel
    {
        public string ProjectTitle { get; set; }
        public string ProjectDetails { get; set; }
        public string Task { get; set; }
        public string TaskHandler { get; set; }
        public string Date { get; set; }
        public int Status { get; set; }
        public IEnumerable<Status> Statuses { get; set; }
    }
}