using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u23601711_HW1.Models;


namespace u23601711_HW1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

   /*     public ActionResult CreateSOSBooking()    
        {
            var randomDriver = DriverRepository.GetDrivers().OrderBy(_ => Guid.NewGuid()).First();
            var randomVehicle = VehicleRepository.GetVehiclesByService(randomDriver.ServiceType).First();

            var booking = new Booking
            {
                ServiceType = randomDriver.ServiceType,
                SelectedDriver = randomDriver,
                SelectedVehicle = randomVehicle,
                Location = "Random Location",
                IsSosBooking = true
            };

            BookingRepository.SaveBooking(booking);

            return RedirectToAction("BookingConfirmed", "Booking", new { id = booking.BookingID });
        } 

*/


    }
}