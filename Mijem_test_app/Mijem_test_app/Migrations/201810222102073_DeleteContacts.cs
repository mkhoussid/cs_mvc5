namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteContacts : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Contacts WHERE Id = 2");
            Sql("DELETE FROM Contacts WHERE Id = 3");
            Sql("DELETE FROM Contacts WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
