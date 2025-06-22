using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23601711_HW1.Models
{
    public class Booking
    {
        public Guid BookingID { get; set; } = Guid.NewGuid();

        public Driver Driver { get; set; }
        public Vehicle Vehicle { get; set; }

        public int ServiceID { get; set; }

        public string ServiceName { get; set; }
        public DateTime BookingDate { get; set; }

        public DateTime PickUpTime { get; set; }
        public string PickUpAddress { get; set; }

        public string Reason { get; set; }//reason ID??

        public bool isSOSBooking { get; set; }

      
    }
}