namespace GarageMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmodel2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Vehicles", newName: "Vehicle");
            CreateTable(
                "dbo.Member",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        PersonalNr = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VehicleType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Vehicle", "MemberId", c => c.Int(nullable: false));
            AddColumn("dbo.Vehicle", "VehicleTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Vehicle", "MemberId");
            CreateIndex("dbo.Vehicle", "VehicleTypeId");
            AddForeignKey("dbo.Vehicle", "MemberId", "dbo.Member", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Vehicle", "VehicleTypeId", "dbo.VehicleType", "Id", cascadeDelete: true);
            DropColumn("dbo.Vehicle", "VehicleType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicle", "VehicleType", c => c.Int(nullable: false));
            DropForeignKey("dbo.Vehicle", "VehicleTypeId", "dbo.VehicleType");
            DropForeignKey("dbo.Vehicle", "MemberId", "dbo.Member");
            DropIndex("dbo.Vehicle", new[] { "VehicleTypeId" });
            DropIndex("dbo.Vehicle", new[] { "MemberId" });
            DropColumn("dbo.Vehicle", "VehicleTypeId");
            DropColumn("dbo.Vehicle", "MemberId");
            DropTable("dbo.VehicleType");
            DropTable("dbo.Member");
            RenameTable(name: "dbo.Vehicle", newName: "Vehicles");
        }
    }
}
