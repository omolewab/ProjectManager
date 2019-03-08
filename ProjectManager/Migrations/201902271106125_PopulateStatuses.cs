namespace ProjectManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStatuses : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status (Id, Name) VALUES (1, 'Completed')");
            Sql("INSERT INTO Status (Id, Name) VALUES (2, 'Started')");
            Sql("INSERT INTO Status (Id, Name) VALUES (3, 'Not Started')");
            Sql("INSERT INTO Status (Id, Name) VALUES (4, 'Cancelled')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Status WHERE Id IN (1,2,3,4)");
        }
    }
}
