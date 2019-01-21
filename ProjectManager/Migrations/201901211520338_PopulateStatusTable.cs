namespace ProjectManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStatusTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status (Id, Name) VALUES (1, 'Completed')");
            Sql("INSERT INTO Status (Id, Name) VALUES (2, 'Almost Complete')");
            Sql("INSERT INTO Status (Id, Name) VALUES (3, 'Started')");
            Sql("INSERT INTO Status (Id, Name) VALUES (4, 'Not Started')");
            Sql("INSERT INTO Status (Id, Name) VALUES (5, 'Cancelled')");

        }

        public override void Down()
        {
            Sql("DELETE FROM Status WHERE Id IN (1, 2, 3, 4, 5)");
        }
    }
}

/* 
 Up
 DropForeignKey("dbo.Projects", "User_Id", "dbo.AspNetUsers");
DropIndex("dbo.Projects", new[] { "User_Id" });
            AlterColumn("dbo.Projects", "ProjectDetails", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.Projects", "TaskHandler", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.Projects", "User_Id", c => c.String(nullable: false, maxLength: 4000));
            CreateIndex("dbo.Projects", "User_Id");
AddForeignKey("dbo.Projects", "User_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);

 down
  DropForeignKey("dbo.Projects", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Projects", new[] { "User_Id" });
            AlterColumn("dbo.Projects", "User_Id", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Projects", "TaskHandler", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Projects", "ProjectDetails", c => c.String(maxLength: 4000));
            CreateIndex("dbo.Projects", "User_Id");
            AddForeignKey("dbo.Projects", "User_Id", "dbo.AspNetUsers", "Id");
     */
