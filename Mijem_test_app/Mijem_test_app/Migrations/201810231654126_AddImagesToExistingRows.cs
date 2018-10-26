namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImagesToExistingRows : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE ImagesUploaded SET ImageURL = '~/Content/asset_uploaded_image.png'");
        }
        
        public override void Down()
        {
        }
    }
}
