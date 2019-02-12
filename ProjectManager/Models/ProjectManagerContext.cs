using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using ProjectManager.Migrations;

namespace ProjectManager.Models
{
    public class ProjectManagerContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Project> Project { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<ProjectTask> Tasks { get; set; }

       

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