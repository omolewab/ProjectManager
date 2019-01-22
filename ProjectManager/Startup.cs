using Microsoft.Owin;
using Owin;
using ProjectManager.Models;

[assembly: OwinStartupAttribute(typeof(ProjectManager.Startup))]
namespace ProjectManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ProjectManagerContext ApplicationContext = new ProjectManagerContext();
            ApplicationContext.Database.Initialize(false);
            ConfigureAuth(app);
        }
    }
}
