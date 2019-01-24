namespace ProjectManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideProjectsAndStatuses : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Projects", "Status_Id", "dbo.Status");
            DropIndex("dbo.Projects", new[] { "Status_Id" });
            AlterColumn("dbo.Projects", "Status_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Projects", "Status_Id");
            AddForeignKey("dbo.Projects", "Status_Id", "dbo.Status", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "Status_Id", "dbo.Status");
            DropIndex("dbo.Projects", new[] { "Status_Id" });
            AlterColumn("dbo.Projects", "Status_Id", c => c.Byte());
            CreateIndex("dbo.Projects", "Status_Id");
            AddForeignKey("dbo.Projects", "Status_Id", "dbo.Status", "Id");
        }
    }
}
