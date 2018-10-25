namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropColumnImageURL : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ReservationDates", "ImageURL");
        }
        
        public override void Down()
        {
        }
    }
}
