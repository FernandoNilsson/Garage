namespace GarageMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validationchanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "RegNr", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Vehicles", "Color", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Vehicles", "Brand", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Vehicles", "Model", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Model", c => c.String());
            AlterColumn("dbo.Vehicles", "Brand", c => c.String());
            AlterColumn("dbo.Vehicles", "Color", c => c.String());
            AlterColumn("dbo.Vehicles", "RegNr", c => c.String());
        }
    }
}
