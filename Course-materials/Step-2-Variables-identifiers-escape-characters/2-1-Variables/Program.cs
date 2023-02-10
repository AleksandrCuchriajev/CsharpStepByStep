using System;
using static System.Formats.Asn1.AsnWriter;

namespace _2_1_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring (Creating) Variables
            // type variableName = value;

            string firstName = "John";
            Console.WriteLine(firstName);

            int num = 5;
            Console.WriteLine(num);

            int num1;
            num1 = 5;
            Console.WriteLine(num1);

            int num2 = 5;
            num2 = 10; // num2 is now 10
            Console.WriteLine(num2);

            double myDouble = 5.99; // or 5.99D
            Console.WriteLine(myDouble);
            char myChar = 'D';
            Console.WriteLine(myChar);
            bool myBoolean = true;
            Console.WriteLine(myBoolean);
            
            // Declare Many Variables
            int x = 5, y = 6, z = 10;
            Console.WriteLine(x + y + z);

            int num3, num4, num5;
            num3 = num4 = num5 = 10;
            Console.WriteLine(num3 + num4 + num5);

        }
    }
}
