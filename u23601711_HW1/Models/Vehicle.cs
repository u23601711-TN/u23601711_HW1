using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23601711_HW1.Models
{
    public class Vehicle
    {

        public int VehicleID { get; set; } //necessary or just reg number??


        public string VehicleType { get; set; }//or integer??

        public string RegistrationNumber { get; set; }
        public int ServiceID { get; set; }
        public string VehicleImage { get; set; }
    }
}