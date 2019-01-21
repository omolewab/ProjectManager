namespace ProjectManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateProjectTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(maxLength: 4000),
                        ProjectDetails = c.String(maxLength: 4000),
                        Task = c.String(maxLength: 4000),
                        TaskHandler = c.String(maxLength: 4000),
                        Status_Id = c.Byte(),
                        User_Id = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.Status_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Projects", "Status_Id", "dbo.Status");
            DropIndex("dbo.Projects", new[] { "User_Id" });
            DropIndex("dbo.Projects", new[] { "Status_Id" });
            DropTable("dbo.Status");
            DropTable("dbo.Projects");
        }
    }
}
