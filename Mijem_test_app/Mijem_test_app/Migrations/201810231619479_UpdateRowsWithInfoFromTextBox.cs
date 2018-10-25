namespace Mijem_test_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRowsWithInfoFromTextBox : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE ReservationDates SET InfoFromTextBox = 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum ut arcu urna. Sed rutrum varius neque pretium sollicitudin. Sed malesuada lorem quis ligula convallis, ut pellentesque velit gravida. Etiam tortor quam, pellentesque vitae quam eget, semper eleifend nunc. Nullam quis augue tellus. Curabitur varius vestibulum nibh vitae mollis. Sed hendrerit nibh at interdum sollicitudin. Nunc sapien tortor, pellentesque ut feugiat eu, dapibus at quam. Etiam quis hendrerit ligula. Pellentesque sit amet varius dui, hendrerit vehicula lectus. Vivamus mollis euismod finibus. Mauris suscipit tristique sapien sed vestibulum'");
        }
        
        public override void Down()
        {
        }
    }
}
