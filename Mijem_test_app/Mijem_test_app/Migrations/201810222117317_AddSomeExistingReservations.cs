namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSomeExistingReservations : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('18 Oct 2018 18:00', 6, 2)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('19 Oct 2018 17:00', 7, 3)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('20 Oct 2018 17:00', 8, 4)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('21 Oct 2018 18:00', 9, 5)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('22 Oct 2018 20:00', 10, 6)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('23 Oct 2018 19:00', 5, 7)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('24 Oct 2018 17:00', 6, 8)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('25 Oct 2018 17:00', 7, 9)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('26 Oct 2018 18:00', 8, 10)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('27 Oct 2018 16:00', 9, 11)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('28 Oct 2018 16:00', 10, 12)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('29 Oct 2018 17:00', 5, 13)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('30 Oct 2018 16:00', 6, 14)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('1 Nov 2018 21:00', 7, 15)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('2 Nov 2018 19:00', 8, 16)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('3 Nov 2018 16:00', 9, 17)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('4 Nov 2018 18:00', 10, 18)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('5 Nov 2018 17:00', 5, 19)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('6 Nov 2018 22:00', 6, 20)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('7 Nov 2018 20:00', 7, 21)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('8 Nov 2018 17:00', 8, 22)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('9 Nov 2018 21:00', 9, 23)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('10 Nov 2018 18:00', 10, 24)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('11 Nov 2018 17:00', 5, 25)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('12 Nov 2018 19:00', 6, 26)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('13 Nov 2018 17:00', 7, 27)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('14 Nov 2018 20:00', 8, 28)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('15 Nov 2018 17:00', 9, 29)");
            Sql("INSERT INTO ReservationDates (ReservedDate, Contact_Id, Reservation_Id) VALUES ('16 Nov 2018 18:00', 10, 30)");
        }
        
        public override void Down()
        {
        }
    }
}
