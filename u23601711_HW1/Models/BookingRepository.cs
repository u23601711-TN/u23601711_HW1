using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23601711_HW1.Models
{
    public class BookingRepository
    {
        private static List<Booking> Bookings = new List<Booking>();

        public static void SaveBooking(Booking booking)
        {
            Bookings.Add(booking);
        }

        public static List<Booking> GetAllBookings() => Bookings;

        public static Booking GetBookingById(System.Guid id) =>  
            Bookings.FirstOrDefault(b => b.BookingID == id);
    }
}