namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSomeContacts : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Contacts (Name, ContactType, ContactNumber, BirthDate) VALUES ('John Smith', 'Cell', 4165551234, '1 Jan 1980')");
            Sql("INSERT INTO Contacts (Name, ContactType, ContactNumber, BirthDate) VALUES ('Mary Williams', 'Cell', 4165551235, '12 Feb 1983')");
            Sql("INSERT INTO Contacts (Name, ContactType, ContactNumber, BirthDate) VALUES ('Jane Smith', 'Work', 4165551236, '18 June 1985')");
            Sql("INSERT INTO Contacts (Name, ContactType, ContactNumber, BirthDate) VALUES ('Robert Downey', 'Cell', 4165551237, '18 June 1985')");
            Sql("INSERT INTO Contacts (Name, ContactType, ContactNumber, BirthDate) VALUES ('Natalie Portman', 'Work', 4165551238, '18 June 1985')");
            Sql("INSERT INTO Contacts (Name, ContactType, ContactNumber, BirthDate) VALUES ('June Robers', 'Work', 4165551239, '18 June 1985')");
        }
        
        public override void Down()
        {
        }
    }
}
