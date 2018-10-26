namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDataTypeOfPhoneNumber : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "ContactNumber", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "ContactNumber", c => c.Int(nullable: false));
        }
    }
}
