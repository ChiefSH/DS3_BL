using DS3_FightclubBlacklist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DS3_FightclubBlacklist.DAL
{
    public class BLInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BLContext>
    {
    
    
    
        protected override void Seed(BLContext context)
        {
            var players = new List<Player>
            {
            new Player{PlayerName="BIG_MONEY_SALVIAxXXxX",EncounterTime=DateTime.Parse("2005-09-01")},
            new Player{PlayerName="Lucarion",EncounterTime=DateTime.Parse("2002-09-01")},
            new Player{PlayerName="Big Moist",EncounterTime=DateTime.Parse("2003-09-01")},
            new Player{PlayerName="Iron Pineapple",EncounterTime=DateTime.Parse("2002-09-01")},
            new Player{PlayerName="Vaati",EncounterTime=DateTime.Parse("2002-09-01")},
            new Player{PlayerName="Solaire",EncounterTime=DateTime.Parse("2001-09-01")},
            new Player{PlayerName="DarkNinjaSlayer99",EncounterTime=DateTime.Parse("2003-09-01")},
            new Player{PlayerName="The Legend",Summary= "Estus Chug",EncounterTime=DateTime.Parse("2005-09-01")}
            };

            players.ForEach(s => context.Players.Add(s));
            context.SaveChanges();
            var Locations = new List<Location>
            {
            new Location{LocationID=1050,LocationName="Farron Keep",LevelRange=100,},
            new Location{LocationID=4022,LocationName="Pontiff Sulyvhan",LevelRange=100,},
            new Location{LocationID=4041,LocationName="Grand Archives",LevelRange=130,},
            new Location{LocationID=1045,LocationName="Kiln of the First Flame",LevelRange=140,},
            new Location{LocationID=3141,LocationName="High Wall",LevelRange=150,},
            new Location{LocationID=2021,LocationName="Profaned Capitol",LevelRange=120,},
            new Location{LocationID=2042,LocationName="Road of Sacrifices",LevelRange=50,}
            };
            Locations.ForEach(s => context.Locations.Add(s));
            context.SaveChanges();
            var blacklists = new List<Blacklist>
            {
            new Blacklist{PlayerID=1,LocationID=1050},
            new Blacklist{PlayerID=1,LocationID=4022},
            new Blacklist{PlayerID=1,LocationID=4041},
            new Blacklist{PlayerID=2,LocationID=1045},
            new Blacklist{PlayerID=2,LocationID=3141},
            new Blacklist{PlayerID=2,LocationID=2021},
            new Blacklist{PlayerID=3,LocationID=1050},
            new Blacklist{PlayerID=4,LocationID=1050,},
            new Blacklist{PlayerID=4,LocationID=4022},
            new Blacklist{PlayerID=5,LocationID=4041},
            new Blacklist{PlayerID=6,LocationID=1045},
            new Blacklist{PlayerID=7,LocationID=3141},
            };
            blacklists.ForEach(s => context.Blacklists.Add(s));
            context.SaveChanges();
        }
    }
}
