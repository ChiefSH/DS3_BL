using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DS3_FightclubBlacklist.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public string Summary { get; set; }
        public DateTime EncounterTime { get; set; }

        //Need to integrate Collections here
    }
}