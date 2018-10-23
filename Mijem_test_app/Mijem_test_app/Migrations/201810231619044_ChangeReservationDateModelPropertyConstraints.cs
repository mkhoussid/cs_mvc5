namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeReservationDateModelPropertyConstraints : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ReservationDates", "Contact_Id", "dbo.Contacts");
            DropForeignKey("dbo.ReservationDates", "Reservation_Id", "dbo.Reservations");
            DropIndex("dbo.ReservationDates", new[] { "Contact_Id" });
            DropIndex("dbo.ReservationDates", new[] { "Reservation_Id" });
            AlterColumn("dbo.ReservationDates", "Contact_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.ReservationDates", "Reservation_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.ReservationDates", "Contact_Id");
            CreateIndex("dbo.ReservationDates", "Reservation_Id");
            AddForeignKey("dbo.ReservationDates", "Contact_Id", "dbo.Contacts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ReservationDates", "Reservation_Id", "dbo.Reservations", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReservationDates", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.ReservationDates", "Contact_Id", "dbo.Contacts");
            DropIndex("dbo.ReservationDates", new[] { "Reservation_Id" });
            DropIndex("dbo.ReservationDates", new[] { "Contact_Id" });
            AlterColumn("dbo.ReservationDates", "Reservation_Id", c => c.Int());
            AlterColumn("dbo.ReservationDates", "Contact_Id", c => c.Int());
            CreateIndex("dbo.ReservationDates", "Reservation_Id");
            CreateIndex("dbo.ReservationDates", "Contact_Id");
            AddForeignKey("dbo.ReservationDates", "Reservation_Id", "dbo.Reservations", "Id");
            AddForeignKey("dbo.ReservationDates", "Contact_Id", "dbo.Contacts", "Id");
        }
    }
}
