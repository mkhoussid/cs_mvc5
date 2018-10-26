namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteRecordsAfterTesting : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Contacts WHERE Id = '3006'");
            Sql("DELETE FROM Contacts WHERE Id = '3007'");
            Sql("DELETE FROM Contacts WHERE Id = '3008'");
            Sql("DELETE FROM Contacts WHERE Id = '3009'");
        }
        
        public override void Down()
        {
        }
    }
}
