namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiredAnnotationToInfoFromTextBoxProperty : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReservationDates", "InfoFromTextBox", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReservationDates", "InfoFromTextBox", c => c.String());
        }
    }
}
