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
            new Vehicle { VehicleID=1, VehicleType="Type 1", RegistrationNumber="AA1234", ServiceID=1, VehicleImage="D1.jpg" },
           new Vehicle { VehicleID=2, VehicleType="Type 1", RegistrationNumber="AA1234", ServiceID=2, VehicleImage="D1.jpg" },
           new Vehicle { VehicleID=3, VehicleType="Type 2", RegistrationNumber="AA1234", ServiceID=3, VehicleImage="D1.jpg" },
           new Vehicle { VehicleID=4, VehicleType="Type 3", RegistrationNumber="AA1234", ServiceID=4, VehicleImage="D1.jpg" }
        };
      
        public static List<Vehicle> GetAllVehicles() => Vehicles;

        public static List<Vehicle> GetVehiclesByService(int ServiceID ) =>
            Vehicles.Where(v => v.ServiceID == ServiceID).ToList();
    }
}