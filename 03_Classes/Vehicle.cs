using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public class Vehicle
    {
        //1 Access Modifier
        //2 Type
        //3 Name
        //4 Getters and Setters

        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public VehicleType TypeOfVehicle {get; set;}
        
    }
    public enum VehicleType {sedan, Truck, Motorcycle, Spaceship, Tractor, FlyingBison} 
}
