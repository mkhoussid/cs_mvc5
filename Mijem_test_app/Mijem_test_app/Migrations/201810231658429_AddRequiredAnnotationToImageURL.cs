namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiredAnnotationToImageURL : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ImagesUploaded", "ImageURL", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ImagesUploaded", "ImageURL", c => c.String());
        }
    }
}
