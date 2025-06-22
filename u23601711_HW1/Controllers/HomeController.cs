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

    public ActionResult CreateSOSBooking()    
        {
            var drivers = DriverRepository.GetDrivers();
            var vehicles = VehicleRepository.GetVehicles();

            var randomDriver = drivers[random.Next(drivers.Count)];
            var randomVehicle = vehicles[random.Next(vehicles.Count)];

            var service = ServiceRepository.GetServiceById(randomDriver.ServiceID);

            var booking = new Booking
            {
                ServiceID = randomDriver.ServiceID,
                Driver = randomDriver,
                Vehicle = randomVehicle,
                PickUpAddress = "SOS booking N/A",
                isSOSBooking = true
            };

            BookingRepository.SaveBooking(booking);

            return RedirectToAction("BookingConfirmed", "Booking", new { id = booking.BookingID });
        } 




    }
}