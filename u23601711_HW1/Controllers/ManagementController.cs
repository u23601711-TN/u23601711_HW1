using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u23601711_HW1.Models;

namespace u23601711_HW1.Controllers
{
    public class ManagementController : Controller
    {
        // GET: Management
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DriverVehicleManagement()
        {
            var drivers = DriverRepository.GetDrivers();
            var vehicles = VehicleRepository.GetVehicles();
            var model = new ManagementVM { Drivers = drivers, Vehicles = vehicles };
            return View(model);
        }
    }
}