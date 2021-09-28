using _07_ClassesNew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ClassesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle firstVehicle = new Vehicle();

            firstVehicle.Make = "Honda";
            firstVehicle.Model = "Civic";
            firstVehicle.Year = 2012;
            firstVehicle.Type = VehicleType.car;
            firstVehicle.Mileage = 150000;
            firstVehicle.Color = "Grey";
        }
    }
}
