using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_ReferenceTypes
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Strings
            string thisIsDeclartion;
            thisIsDeclartion = "This is initiallized";

            string declartionAndInitiallized = "This is both declartion and initiallized a string";

           // Console.WriteLine("What is your first name?");
           // string firstname = Console.ReadLine();
           // Console.WriteLine(firstname);

            //String Operation 
            //Concatenation
            string concatenatedFullName;
            string firstName = "Joshua";
            string lastName = "Middleton";
            concatenatedFullName = firstName + " " + lastName;
            Console.WriteLine(concatenatedFullName);

            //Interpolation
            string interpolationFullName = $"{firstName} {lastName}";
            Console.WriteLine(interpolationFullName);

            //Collections
            //List
            



            //Array
            string[] arrayOfString = new string[8];
            string[] anotherArrayOfStrings = { firstName, lastName, "blahblah" };

            //Queue
            


            //Dictionary
        
        }
    }
}
