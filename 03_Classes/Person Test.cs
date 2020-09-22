using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Classes
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void TestPerson()
        {
            Person firstPerson = new Person("Howard", "Stefanopoulous", new DateTime(1785, 02, 14), new Vehicle());

            firstPerson.Transport.Make = "Tesla";
            firstPerson.Transport.Model = "CyberTruck";
            firstPerson.Transport.Mileage = 2;
            firstPerson.Transport.TypeOfVehicle = VehicleType.Truck;

            Vehicle CyberTruck = firstPerson.Transport;
            

        }
    }
}
