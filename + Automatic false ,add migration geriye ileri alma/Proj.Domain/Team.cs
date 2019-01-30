using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Domain
{
  public  class Team
    {
        public Team()
        {
            Players = new List<Player>();
            Sponsors = new List<Sponsor>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime KurulusYili { get; set; }
        public ICollection<Player> Players { get; set; }
        public ICollection<Sponsor> Sponsors { get; set; }
        public Country Country { get; set; }
    }
}
