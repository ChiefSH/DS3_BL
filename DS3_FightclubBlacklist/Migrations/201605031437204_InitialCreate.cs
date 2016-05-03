namespace DS3_FightclubBlacklist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blacklist",
                c => new
                    {
                        BlacklistID = c.Int(nullable: false, identity: true),
                        LocationID = c.Int(nullable: false),
                        PlayerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BlacklistID)
                .ForeignKey("dbo.Location", t => t.LocationID, cascadeDelete: true)
                .ForeignKey("dbo.Player", t => t.PlayerID, cascadeDelete: true)
                .Index(t => t.LocationID)
                .Index(t => t.PlayerID);
            
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        LocationID = c.Int(nullable: false),
                        LocationName = c.String(),
                        LevelRange = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LocationID);
            
            CreateTable(
                "dbo.Player",
                c => new
                    {
                        PlayerID = c.Int(nullable: false, identity: true),
                        PlayerName = c.String(),
                        Summary = c.String(),
                        EncounterTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PlayerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blacklist", "PlayerID", "dbo.Player");
            DropForeignKey("dbo.Blacklist", "LocationID", "dbo.Location");
            DropIndex("dbo.Blacklist", new[] { "PlayerID" });
            DropIndex("dbo.Blacklist", new[] { "LocationID" });
            DropTable("dbo.Player");
            DropTable("dbo.Location");
            DropTable("dbo.Blacklist");
        }
    }
}
