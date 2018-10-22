namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameVenueNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Reservations SET Name = 'Second Dock' WHERE Id = 1");
            Sql("UPDATE Reservations SET Name = 'Primer Puerto' WHERE Id = 2");
            Sql("UPDATE Reservations SET Name = 'Stella' WHERE Id = 3");
            Sql("UPDATE Reservations SET Name = 'Island Creek' WHERE Id = 4");
            Sql("UPDATE Reservations SET Name = 'Fogo The Chao' WHERE Id = 5");
            Sql("UPDATE Reservations SET Name = 'Fontana' WHERE Id = 6");
            Sql("UPDATE Reservations SET Name = 'Sage Gateshead' WHERE Id = 7");
            Sql("UPDATE Reservations SET Name = 'London Astoria' WHERE Id = 8");
            Sql("UPDATE Reservations SET Name = 'Denny Sanford' WHERE Id = 9");
            Sql("UPDATE Reservations SET Name = 'Huntington Center' WHERE Id = 10");
            Sql("UPDATE Reservations SET Name = 'KOKO' WHERE Id = 11");
            Sql("UPDATE Reservations SET Name = 'Patricia&Arthur' WHERE Id = 12");
            Sql("UPDATE Reservations SET Name = 'Ascend' WHERE Id = 13");
            Sql("UPDATE Reservations SET Name = 'The Amphitheatre' WHERE Id = 14");
            Sql("UPDATE Reservations SET Name = 'Commodore Ballroom' WHERE Id = 15");
            Sql("UPDATE Reservations SET Name = 'Orhpeum' WHERE Id = 16");
            Sql("UPDATE Reservations SET Name = 'Greek Theatre' WHERE Id = 17");
            Sql("UPDATE Reservations SET Name = 'KM de Vantagens' WHERE Id = 18");
            Sql("UPDATE Reservations SET Name = 'Joiners Arms' WHERE Id = 19");
            Sql("UPDATE Reservations SET Name = 'Verizon Theatre' WHERE Id = 20");
            Sql("UPDATE Reservations SET Name = 'El Rey' WHERE Id = 21");
            Sql("UPDATE Reservations SET Name = 'King Tuts' WHERE Id = 22");
            Sql("UPDATE Reservations SET Name = 'Convene' WHERE Id = 23");
            Sql("UPDATE Reservations SET Name = 'The Citi' WHERE Id = 24");
            Sql("UPDATE Reservations SET Name = 'Wide Rainje' WHERE Id = 25");
            Sql("UPDATE Reservations SET Name = 'Jericho' WHERE Id = 26");
            Sql("UPDATE Reservations SET Name = 'Personified' WHERE Id = 27");
            Sql("UPDATE Reservations SET Name = 'FunAintItTho' WHERE Id = 28");
            Sql("UPDATE Reservations SET Name = 'BallRoom Venue Place' WHERE Id = 29");
            Sql("UPDATE Reservations SET Name = 'Final Lace' WHERE Id = 30");
        }
        
        public override void Down()
        {
        }
    }
}
