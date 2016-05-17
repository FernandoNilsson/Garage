namespace GarageMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class checkouttime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "CheckOutTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "CheckOutTime");
        }
    }
}
