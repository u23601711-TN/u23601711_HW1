using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23601711_HW1.Models
{
    public class DriverRepository
    {

        private static List<Driver> Drivers = new List<Driver>
        {
           //return new List<Driver>();
            
            new Driver { DriverID = 1, DriverFirstName = "Anele", DriverLastName = "Naidoo", DriverPhone = "+27 82 456 7890", DriverImage = "D1.jpg", ServiceID = 1 },
            new Driver { DriverID = 2, DriverFirstName = "Lerato", DriverLastName = "Goldberg", DriverPhone = "+27 61 234 5678", DriverImage = "D1.jpg", ServiceID = 2 },
            new Driver { DriverID = 3, DriverFirstName = "Yusuf", DriverLastName = "van der Merwe", DriverPhone = "+27 84 789 6543", DriverImage = "D1.jpg", ServiceID = 3 },
            new Driver { DriverID = 4, DriverFirstName = "Megan", DriverLastName = "Mokoena", DriverPhone = "+27 72 555 6789", DriverImage = "D1.jpg", ServiceID = 4 },
            new Driver { DriverID = 5, DriverFirstName = "Siyabonga", DriverLastName = "Moodley", DriverPhone = "+27 78 901 2345", DriverImage = "D1.jpg", ServiceID = 5 },
            new Driver { DriverID = 6, DriverFirstName = "Farah", DriverLastName = "Dlamini", DriverPhone = "+27 79 876 5432", DriverImage = "D1.jpg", ServiceID = 6 },
            new Driver { DriverID = 7, DriverFirstName = "Jason", DriverLastName = "Khumalo", DriverPhone = "+27 60 987 1234", DriverImage = "D1.jpg", ServiceID = 1 }

        };

        public static List<Driver> GetDrivers()
        {
            return Drivers;
        }

        public static List<Driver> GetDriversByServiceID(int ServiceID)
        {
            return Drivers.Where(d => d.ServiceID == ServiceID).ToList();
        }


    }
}