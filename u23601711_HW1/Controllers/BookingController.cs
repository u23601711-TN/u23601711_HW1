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

        
        public ActionResult BookingForm(int ServiceId)
        {
            var service = ServiceRepository.GetServiceById(ServiceId);
            var model = new BookingVM
            {
                ServiceId = service.ServiceID,
                ServiceName = service.ServiceName,
                Drivers = DriverRepository.GetDriversByServiceID(service.ServiceID),
                Vehicles = VehicleRepository.GetVehiclesByServiceID(service.ServiceID)
            };
            return View(model);
        }
         

        [HttpPost]                              //NB add pick up time here and in view
        public ActionResult SubmitBooking(Guid driverId, Guid vehicleId, string location, DateTime pickUpTime, int serviceId)
        {
            var service = ServiceRepository.GetServiceById(serviceId);
            var driver = DriverRepository.GetDrivers().Find(d => d.DriverID == driverId);
            var vehicle = VehicleRepository.GetVehicles().Find(v => v.VehicleID == vehicleId);

            var booking = new Booking
            {
                ServiceID = service.ServiceID,
                ServiceName= service.ServiceName,
                Driver = driver,
                Vehicle = vehicle,
                PickUpAddress = location,
                PickUpTime = pickUpTime,
                isSOSBooking = false
            };

            BookingRepository.SaveBooking(booking);
            return RedirectToAction("BookingConfirmed", booking.BookingID );
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