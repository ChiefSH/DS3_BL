using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace DS3_FightclubBlacklist.Models
{
    public class Location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public int LevelRange { get; set; }

        public virtual ICollection<Blacklist> Blacklists { get; set; }
    }
}