namespace ProjectManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserTasks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserTasks",
                c => new
                    {
                        TaskId = c.Int(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.TaskId, t.UserId })
                .ForeignKey("dbo.ProjectTasks", t => t.TaskId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.TaskId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTasks", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserTasks", "TaskId", "dbo.ProjectTasks");
            DropIndex("dbo.UserTasks", new[] { "UserId" });
            DropIndex("dbo.UserTasks", new[] { "TaskId" });
            DropTable("dbo.UserTasks");
        }
    }
}
