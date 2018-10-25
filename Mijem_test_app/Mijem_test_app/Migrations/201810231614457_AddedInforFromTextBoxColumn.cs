namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInforFromTextBoxColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReservationDates", "InfoFromTextBox", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReservationDates", "InfoFromTextBox");
        }
    }
}
