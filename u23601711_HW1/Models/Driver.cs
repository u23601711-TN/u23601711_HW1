using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23601711_HW1.Models
{
    public class Driver
    {
        public Guid DriverID { get; set; } = Guid.NewGuid();

        public string DriverFirstName { get; set; }

        public string DriverLastName { get; set; }

        public string DriverPhone { get; set; }
        public int ServiceID { get; set; }
        public string DriverImage { get; set; }


    }
}