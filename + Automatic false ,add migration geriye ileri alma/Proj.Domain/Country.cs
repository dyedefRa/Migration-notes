using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Domain
{
  public  class Country
    {
        public Country()
        {
            Teams = new List<Team>();
        }
        public int Id { get; set; }
        public string Ad { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
