namespace ProjectManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjectTask : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProjectTasks",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    TaskTitle = c.String(maxLength: 4000),
                    TaskHandler = c.String(maxLength: 4000),
                    Project_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Project_Id);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectTasks", "Project_Id", "dbo.Projects");
            DropIndex("dbo.ProjectTasks", new[] { "Project_Id" });
            DropTable("dbo.Projects");
            DropTable("dbo.ProjectTasks");
        }
    }
}
