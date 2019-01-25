using System.ComponentModel.DataAnnotations;

namespace ProjectManager.Models
{
    public class Status
    {
        [Required]
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }
    }

    public enum StatusEnum
    {
        Completed = 1,
        Almost_Complete = 2,
        Started = 3
    }
}