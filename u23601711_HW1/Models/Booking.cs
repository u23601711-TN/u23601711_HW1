using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23601711_HW1.Models
{
    public class Booking
    {
        public Guid BookingID { get; set; } = Guid.NewGuid();

        public int DriverID { get; set; }
        public int VehicleID { get; set; }
        public DateTime BookingDate { get; set; }

        public DateTime PickUpTime { get; set; }
        public string PickUpAddress { get; set; }

        //SOS booking?????????????????? reason??
    }
}