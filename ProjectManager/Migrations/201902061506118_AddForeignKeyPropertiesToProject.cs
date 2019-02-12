namespace ProjectManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToProject : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Projects", name: "Status_Id", newName: "StatusId");
            RenameColumn(table: "dbo.Projects", name: "User_Id", newName: "UserId");
            RenameIndex(table: "dbo.Projects", name: "IX_User_Id", newName: "IX_UserId");
            RenameIndex(table: "dbo.Projects", name: "IX_Status_Id", newName: "IX_StatusId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Projects", name: "IX_StatusId", newName: "IX_Status_Id");
            RenameIndex(table: "dbo.Projects", name: "IX_UserId", newName: "IX_User_Id");
            RenameColumn(table: "dbo.Projects", name: "UserId", newName: "User_Id");
            RenameColumn(table: "dbo.Projects", name: "StatusId", newName: "Status_Id");
        }
    }
}
