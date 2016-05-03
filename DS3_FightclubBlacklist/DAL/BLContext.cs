using DS3_FightclubBlacklist.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DS3_FightclubBlacklist.DAL
{
    public class BLContext : DbContext
    {

        public BLContext() : base("BLContext")
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Blacklist> Blacklists { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
