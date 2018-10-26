namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeeDListOfAllVenues : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Second Dock', 1, 1)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Primer Puerto', 2, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Stella', 4, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Island Creek', 5, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Fogo The Chao', 3, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Fontana', 4, 1)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Second Dock', 2, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Primer Puerto', 1, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Stella', 4, 1)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Island Creek', 4, 1)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Fogo The Chao', 2, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Fontana', 1, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Second Dock', 5, 1)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Primer Puerto', 4, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Stella', 2, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Island Creek', 1, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Fogo The Chao', 3, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Fontana', 4, 1)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Second Dock', 3, 1)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Primer Puerto', 3, 1)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Stella', 5, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Island Creek', 1, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Fogo The Chao', 2, 1)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Fontana', 4, 1)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Second Dock', 3, 1)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Primer Puerto', 2, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Stella', 4, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Island Creek', 1, 1)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Fogo The Chao', 3, 0)");
            Sql("INSERT INTO Reservations (Name, Ranking, Favorites) VALUES ('Fontana', 4, 1)");
        }
        
        public override void Down()
        {
        }
    }
}