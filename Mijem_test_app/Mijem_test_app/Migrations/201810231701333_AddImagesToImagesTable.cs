namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImagesToImagesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ImagesUploaded (ImageURL) VALUES ('~/Content/asset_uploaded_image.png')");
        }
        
        public override void Down()
        {
        }
    }
}
