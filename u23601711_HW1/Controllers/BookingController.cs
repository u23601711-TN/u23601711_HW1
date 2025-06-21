using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u23601711_HW1.Models;

namespace u23601711_HW1.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectService()
        {
            var Services = ServiceRepository.GetServices(); 
            return View(Services);
        }

        public ActionResult BookingForm()
        {
            return View();
        }

        public ActionResult BookingConfirmed(Guid Id)
        {
            var Booking = BookingRepository.GetBookingById(Id);
            return View(Booking);
        }

        public ActionResult RideHistory()
        {
            var Bookings = BookingRepository.GetAllBookings();
            return View(Bookings);
        }

    }
}