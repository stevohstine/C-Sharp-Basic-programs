using System;
using static System.Console;

namespace Workmodulus
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            decimal output;
            WriteLine("Enter a number to test if it is an even number:");
            number = Convert.ToInt32(ReadLine());
            output = number % 2;
            if (output == 0)
            {
                WriteLine("The number is an even number");
            }
            else
            {
                WriteLine("The number is odd number");
            }

            ReadKey();
        }
    }
}
