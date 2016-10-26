using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace S00152497Clubs.Models.ClubsModel
{
    public class ClubsContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubEvent> ClubEvents { get; set; }

        public ClubsContext() : base("DefaultConnection")
        {

        }

        public static ClubsContext Create()
        {
            return new ClubsContext();
        }
    }
}