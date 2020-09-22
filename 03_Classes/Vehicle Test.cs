using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Classes
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void properties()
        {
            Vehicle civic = new Vehicle();
            civic.Make = "Honda";
            civic.Model = "Civic";
            civic.Mileage = 6000;
            civic.TypeOfVehicle = VehicleType.sedan;
        }
    }
}
