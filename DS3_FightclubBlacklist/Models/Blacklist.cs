using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DS3_FightclubBlacklist.Models
{

    //public enum Grade     will probably remake this to function as the severity system
    //{
     //   A, B, C, D, F
    //}

    public class Blacklist
    {
        public int BlacklistID { get; set; }
        public int LocationID { get; set; }
        public int PlayerID { get; set; }
        //public string Summary { get; set; }     need to integrate this in later
        //public Grade? Grade { get; set; }

        public virtual Location Location { get; set; }
        public virtual Player Player { get; set; }
    }
}
