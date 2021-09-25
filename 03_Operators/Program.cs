using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 7;
            int numTwo = 20;
            int sum = numOne + numTwo;
            Console.WriteLine(sum);


            int differance = numTwo - numOne ;
            Console.WriteLine(differance);


            int product = numOne * numTwo;
            Console.WriteLine(product);

            int quotient = numOne / numTwo;
            Console.WriteLine(quotient);

            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            //TimeSpan
            DateTime today = DateTime.Now;
            DateTime sumDay = new DateTime(2000, 5, 20);
            TimeSpan timeSpan = today - sumDay;
            Console.WriteLine(timeSpan);

            //Convertions
            //Casting
            //Type name= (castType)value
            int six = 6;
            double doubleSix = (double)six;
            Console.WriteLine(doubleSix);

            char a = 'a';
            int valueA = (int)a;
            Console.WriteLine(valueA);

            //string myString = "This a string";
            //byte myByte = (byte)myString;

            decimal myMoney = 5.87m;
            int intMoney = (int)myMoney; // 5


            //Conversion
            // type = convert.toType(value)

            int Five = 5;
            decimal decimalFive = Convert.ToDecimal(Five);

            decimal decimalTwo = 2.55m;
            int intTwo = Convert.ToInt32(decimalTwo);

            //Parsing
            string decimalString = "5.69878";
            decimal decimalValue = decimal.Parse(decimalString);

            //Comparison Operators
            Console.WriteLine("Enter your age");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            Console.WriteLine("Enter your name");
            string userName = Console.ReadLine();

            bool equals = age == 41;
            Console.WriteLine(equals);

            bool notequals = age != 41;
            Console.WriteLine("User is not 41: (notEquals)");
            Console.WriteLine(notequals);


            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

           bool listAreEqual =  firstList == secondList;
            Console.WriteLine("List are equal: " + listAreEqual);

             bool greaterThan = age > 12;
             bool greaterThanOrEqual = age >= 55;
             bool lessThan = age < 1;
             bool lessThanOrEqual = age <= 99;

            bool orValue = equals || notequals;

            bool tOrT = true || true;
            bool tOrF = true || false;
            bool fOrT = false || true;
            bool fOrF = false || false;

            bool andValue = equals && notequals;
            
             tOrT = true && true;
             tOrF = true && false;
             fOrT = false && true;
             fOrF = false && false;

            int x = 13;
           bool test= x < 44 && x > 10;
            Console.WriteLine(test);

            int y = 10;

            bool test2 = y > 20 || y < 15; // Is 10>20 or is 10<15?
            Console.WriteLine(test2);








            Console.ReadLine();
        }
    }
}
