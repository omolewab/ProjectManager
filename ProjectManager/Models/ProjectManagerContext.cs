using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ProjectManager.Models
{
    public class ProjectManagerContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Status> Statuses { get; set; }


        public ProjectManagerContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ProjectManagerContext Create()
        {
            return new ProjectManagerContext();
        }
    }
}