using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Domain
{
  public  class PlayerAddress
    {
        //Buradaki Key i ben verdım.
        //Yoksa olmuyordu Key yok diyor 
        [ForeignKey("Player"),Key]
        public int PlayerAdressID { get; set; }
        public string City { get; set; }
        public int Street { get; set; }
        public int PostCode { get; set; }
        public Player Player { get; set; }
    }
}
