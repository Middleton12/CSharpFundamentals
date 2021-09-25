using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Methods
{
    [TestClass]
    public class MethodExamples
    {
        [TestMethod]

        public void MethodExecution()
        {
            SayHello("Joshua");
            int methodReturn = AddTwoNumbers(1, 2);
            Console.WriteLine(methodReturn);

           AddTwoNumbers(3.06, 2.56);
           AddTwoNumbers(3, 2.55);
            int value = (int)AddTwoNumbers(3.66, 1);

            int age = CalculateAge(new DateTime(1989, 10, 20));
            Console.WriteLine($"My age is:{age}");
        }

            //1) Access Modifier
            //2) Return Type
            //3) Method Signature
            // Name
            // Parameters
            //4) Body - the actual code
            [TestMethod]
            public void SayHello(string name)
            {
                Console.WriteLine($"Hello World! and Hello {name}!");
            }
            [TestMethod]

            public int AddTwoNumbers(int numOne, int numTwo)
            {
                int sum = numOne + numTwo;
                return sum;

            }
            [TestMethod]
             
            public double AddTwoNumbers(double numOne, double numTwo)
            {
                double sum = numOne + numTwo;
                return sum;
            }
            [TestMethod]

            public int CalculateAge(DateTime birhtday)
        {

        }

        
     }
}
