namespace GarageMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vehicle", "MemberId", "dbo.Member");
            DropIndex("dbo.Vehicle", new[] { "MemberId" });
            AlterColumn("dbo.Vehicle", "MemberId", c => c.Int());
            CreateIndex("dbo.Vehicle", "MemberId");
            AddForeignKey("dbo.Vehicle", "MemberId", "dbo.Member", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicle", "MemberId", "dbo.Member");
            DropIndex("dbo.Vehicle", new[] { "MemberId" });
            AlterColumn("dbo.Vehicle", "MemberId", c => c.Int(nullable: false));
            CreateIndex("dbo.Vehicle", "MemberId");
            AddForeignKey("dbo.Vehicle", "MemberId", "dbo.Member", "Id", cascadeDelete: true);
        }
    }
}
