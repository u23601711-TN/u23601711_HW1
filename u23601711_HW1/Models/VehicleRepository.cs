using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23601711_HW1.Models
{
    public class VehicleRepository
    {
        private static List<Vehicle> Vehicles = new List<Vehicle>
        {
           new Vehicle { VehicleType="Type 1", RegistrationNumber="AA1234", ServiceID=1, VehicleImage="/content/images/D1.jpg" },
           new Vehicle { VehicleType="Type 1", RegistrationNumber="AA4565", ServiceID=2, VehicleImage="/content/images/D1.jpg" },
           new Vehicle { VehicleType="Type 2", RegistrationNumber="AA5864", ServiceID=3, VehicleImage="/content/images/D1.jpg" },
           new Vehicle { VehicleType="Type 2", RegistrationNumber="AA0987", ServiceID=4, VehicleImage="/content/images/D1.jpg" },
           new Vehicle { VehicleType="Type 3", RegistrationNumber="AA7638", ServiceID=5, VehicleImage="/content/images/D1.jpg" },
           new Vehicle { VehicleType="Type 3", RegistrationNumber="AA3580", ServiceID=6, VehicleImage="/content/images/D1.jpg" }
        };
      
        public static List<Vehicle> GetVehicles() => Vehicles;

        public static List<Vehicle> GetVehiclesByServiceID(int ServiceID ) =>
            Vehicles.Where(v => v.ServiceID == ServiceID).ToList();
    }
}