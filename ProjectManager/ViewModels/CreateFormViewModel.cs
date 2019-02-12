using ProjectManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManager.ViewModels
{
    public class CreateFormViewModel
    {
        [Required]
        public string ProjectTitle { get; set; }
        [Required]
        public string ProjectDetails { get; set; }
        [Required]
        public string Task { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        public int Status { get; set; }
        public IEnumerable<Status> Statuses { get; set; }
    }
}