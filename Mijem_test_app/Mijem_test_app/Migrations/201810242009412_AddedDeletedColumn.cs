namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDeletedColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReservationDates", "Deleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReservationDates", "Deleted");
        }
    }
}
