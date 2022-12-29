using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLAPI.DO
{
    public class Bus
    {
        public DateTime FromDate { get; set; }
        public int  FuelRemain { get; set; }
        public int LicencePlate {get;set;}
        public Enums.Status Status { get; set; } 
        public int  TotalTrip { get; set; }
  
    }
}
