namespace GarageMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enums : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "VehicleType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "VehicleType", c => c.String());
        }
    }
}
