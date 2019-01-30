using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Domain
{
 public   class FutbolContext:DbContext
    {
        public FutbolContext():base("FutbolConStr")
        {

        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerAddress> Adresses { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
