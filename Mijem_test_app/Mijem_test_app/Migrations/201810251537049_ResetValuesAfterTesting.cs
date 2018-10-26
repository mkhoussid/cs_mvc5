namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResetValuesAfterTesting : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE ReservationDates SET Deleted = 'false'");
        }
        
        public override void Down()
        {
        }
    }
}
