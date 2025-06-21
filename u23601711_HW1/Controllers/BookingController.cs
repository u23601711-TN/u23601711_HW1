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
        /*
                public ActionResult BookingForm(int ServiceId)
                {
                    var service = ServiceRepository.GetServiceById(serviceTypeId);
                    var model = new BookingFormViewModel
                    {
                        ServiceId = service.Id,
                        ServiceName = service.Name,
                        Drivers = DriverRepository.GetDriversByService(service.Id),
                        Vehicles = VehicleRepository.GetVehiclesByService(service.Id)
                    };
                    return View(model);
                }
       */  /*

                [HttpPost]
                public ActionResult SubmitBooking(Guid driverId, Guid vehicleId, string location, int serviceId)
                {
                    var service = ServiceRepository.GetServiceById(serviceId);
                    var driver = DriverRepository.GetAllDrivers().Find(d => d.DriverId == driverId);
                    var vehicle = VehicleRepository.GetAllVehicles().Find(v => v.VehicleId == vehicleId);

                    var booking = new Booking
                    {
                        ServiceId = service.Id,
                        ServiceName = service.Name,
                        SelectedDriver = driver,
                        SelectedVehicle = vehicle,
                        Location = location,
                        IsSosBooking = false
                    };

                    BookingRepository.SaveBooking(booking);
                    return RedirectToAction("BookingConfirmed", new { id = booking.BookingId });
                }
        */
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