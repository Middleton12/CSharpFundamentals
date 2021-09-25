using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_ValueTypes
{
    [TestClass]
    public class ValueTypes
    {
        public enum PasteryType
        {
            Cake,
            Danish,
            Donut
        }
        [TestMethod]
        public void InitAndDeclareVariables()
        {
            int numOne;
            numOne = 1;

            int numTwo = 2;

            //Variable
            //named loaction in computer memory AKA RAM
        }

        [TestMethod]
        public void ValueTypeVariables()
        {
            //Whole Numbers
            byte byteExample = 255;
            sbyte sByteExample = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            int intMax = 2147483647;
            Int32 anotherIntExample = 123456;
            long LongMax = 9223372036854775007;
            Int64 longMin = -9223372036854775808;

            //Decimals
            double doubleExample = 1.23456789;
            float floatExample = 1.23456789f;
            decimal decimalExample = 1.24567894561230m;

            Console.WriteLine(doubleExample);


            //Character

            char charExample = 'a';
            char number = '3';
            char symbol = '&';
            char space = ' ';
            char specialChar = '\n';

            //Bool
            bool isHungry = true;
            bool isTired = false;

            //Enum
            PasteryType myPastry = PasteryType.Cake;

            //Structs
            DateTime today = DateTime.Now;
            Console.WriteLine(today);

        }
    }
}
