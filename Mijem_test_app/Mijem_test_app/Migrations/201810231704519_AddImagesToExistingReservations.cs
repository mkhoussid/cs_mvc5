namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImagesToExistingReservations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReservationDates", "ImageURL", c => c.String());
            
        }
        
        public override void Down()
        {
        }
    }
}
