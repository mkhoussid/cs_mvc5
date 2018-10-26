namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImageModelAndImageURLFieldInReservationDates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImagesUploaded",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ReservationDates", "ImageURL_Id", c => c.Int());
            CreateIndex("dbo.ReservationDates", "ImageURL_Id");
            AddForeignKey("dbo.ReservationDates", "ImageURL_Id", "dbo.ImagesUploaded", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReservationDates", "ImageURL_Id", "dbo.ImagesUploaded");
            DropIndex("dbo.ReservationDates", new[] { "ImageURL_Id" });
            DropColumn("dbo.ReservationDates", "ImageURL_Id");
            DropTable("dbo.ImagesUploaded");
        }
    }
}
