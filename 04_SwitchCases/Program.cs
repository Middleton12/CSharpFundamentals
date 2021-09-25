using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello World!");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is default.If will be executed if no other case is evaluted.");
                    break;
            }

            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch (today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Welcome to the beginning of a work week");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Still working");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's The Weekend!");
                    break;    
            }
  
            //Challenge
            // Ask the user how they are feeling on a scale from 1-5.Capture their input and run it thro

            Console.WriteLine("How do you feel on a scale from 1-5?");
            int feeling = int.Parse(Console.ReadLine());

            switch (feeling)
            {
                case 1:
                    Console.WriteLine("Call 911!");
                        break;
                case 2:
                case 3:
                    Console.WriteLine("Call your Doctor!");
                    break;
                case 4:
                    Console.WriteLine("Your feeling ok!");
                    break;
                case 5:
                    Console.WriteLine("Your feeling great!!");
                    break;
                default:
                    Console.WriteLine("It look like you have entered a value beyond 1-5");
                    break;
            }

       
     
            Console.ReadKey();
        }
       
    }
}
