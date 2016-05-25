namespace GarageMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Garage25 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Member", "PersonalNr", c => c.String(nullable: false, maxLength: 12));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Member", "PersonalNr", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
