using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u23601711_HW1.Models;
//@model u23601711_HW1.viewmodels.
namespace u23601711_HW1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public List<Service> Services = new List<Service>
        {
            new Service{ServiceID = 1, ServiceAbbreviation = "ALS", ServiceName = "Advanced Life Support", ServiceDescription="ALS ambulance is staffed by a Paramedic and is used to transport patients who require high level of care", ServiceImage="D1.jpg"},
            new Service{ServiceID = 2, ServiceAbbreviation = "BLS", ServiceName = "Basic Life Support", ServiceDescription="BLS ambulance is provides transport to patients who are in a non life threatening condition", ServiceImage="D1.jpg"},
            new Service{ServiceID = 3, ServiceAbbreviation = null, ServiceName = "Patient Transport", ServiceDescription="The most basic type of transport for patients requiring ambulatory support to and from the hospital", ServiceImage="D1.jpg"},
            new Service{ServiceID = 4, ServiceAbbreviation = null, ServiceName = "Medical Utility Vehicle", ServiceDescription="A state-of-the-art small of large van that is designed to facilitate the movement and transport of patients", ServiceImage="D1.jpg"},
            new Service{ServiceID = 5, ServiceAbbreviation = null, ServiceName = "Event Medical Ambulance", ServiceDescription="Ambulances that are stationed at events, such as concerts, sports games, and festivals, to provide medical assistance", ServiceImage="D1.jpg"},
            new Service{ServiceID = 6, ServiceAbbreviation = null, ServiceName = "Air ambulance", ServiceDescription="Air ambulance help in the transfer of patients across long distances in both emergency and non-emergency situations", ServiceImage="D1.jpg"},
        };

        public ActionResult testing()
        {
            DriverViewModel viewModel = new DriverViewModel
            {
                Drivers = DriverRespository.Drivers
            };
            return View(viewModel);
        }


    }
}