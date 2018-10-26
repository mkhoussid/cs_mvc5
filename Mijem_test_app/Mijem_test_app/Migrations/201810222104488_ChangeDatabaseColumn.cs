namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDatabaseColumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "BirthDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "BirthDate", c => c.DateTime(nullable: false));
        }
    }
}
