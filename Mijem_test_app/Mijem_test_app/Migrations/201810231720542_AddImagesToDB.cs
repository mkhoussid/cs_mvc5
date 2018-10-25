namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImagesToDB : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE ReservationDates SET ImageURL_Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
