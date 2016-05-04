namespace DS3_FightclubBlacklist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Catchup : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Player", "EncounterTime", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Player", "EncounterTime", c => c.DateTime(nullable: false));
        }
    }
}
