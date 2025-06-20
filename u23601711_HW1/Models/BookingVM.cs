using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23601711_HW1.Models
{
    public class BookingVM
    {
        public List<Service> Services { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}