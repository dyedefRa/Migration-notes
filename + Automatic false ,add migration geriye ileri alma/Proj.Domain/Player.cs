using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Domain
{
    [Table("Players")]
 public   class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public Team Team { get; set; }
        public PlayerAddress Address { get; set; }
    }
}
