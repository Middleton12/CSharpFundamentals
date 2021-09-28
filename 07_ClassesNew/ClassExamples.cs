using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ClassesNew
{
    public enum VehicleType { car,suv,truck}
    public class Vehicle
    {
        // accessmodifer -- type -- propertyName-- {get; set;}
        public string Make { get; set; }
        public int  Year { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Mileage { get; set; }

        public VehicleType Type { get; set; }
       
        public Vehicle()
        {

        }
        public Vehicle(string make,string model,int year, double milage,string color, VehicleType type)
        {
            Make = make;
            Year = year;
            Model = model;
            Color = color;
            Mileage = milage;
            Type = type;

           
        }


    }
    public class Person
    {
        //age
        //height
        //gender
        //weight
        //DateOfBirth
        //firstName
        //lastNmae

        public string firstName { get; set; }

    }
}
