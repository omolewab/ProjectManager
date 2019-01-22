using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using ProjectManager.Migrations;

namespace ProjectManager.Models
{
    public class ProjectManagerContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Project> Projects { get; set; }
        public DbSet<Status> Statuses { get; set; }

       

        public ProjectManagerContext()
            : base("name=ProjectManagerContext", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProjectManagerContext, Configuration>());
        }

        public static ProjectManagerContext Create()
        {
            return new ProjectManagerContext();
        }
    }
}