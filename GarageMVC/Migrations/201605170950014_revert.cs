namespace GarageMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class revert : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Vehicles", "CheckOutTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicles", "CheckOutTime", c => c.DateTime(nullable: false));
        }
    }
}
