using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public FileResult ExportVehicles()
        {
            var vehicles = VehicleRepository.GetVehicles();
            List<string> lines = new List<string>();

            foreach (var v in vehicles)
            {
                string line = v.VehicleType + "," + v.RegistrationNumber + "," + v.ServiceID;
                lines.Add(line);
            }

            string fileContent = string.Join("\n", lines);
            var bytes = Encoding.UTF8.GetBytes(fileContent);

            return File(bytes, "text/plain", "Vehicles.txt");
        }
    }
}