namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnImagesForReservationDates : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE ReservationDates SET ImageURL = 1");
        }
        
        public override void Down()
        {
        }
    }
}
