using System;

using static System.Console;

namespace greaterofTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            WriteLine("Enter first number");
            num1 = Convert.ToInt32(ReadLine());
            WriteLine("Enter second number");
            num2 = Convert.ToInt32(ReadLine());
            if (num1 > num2) 
            {
                WriteLine($"{num1} is greater than {num2}");
            }
            else if(num2>num1)
            {
                WriteLine($"{num2} is greater than {num1}");
            }
            else
            {
                WriteLine($"{num1} is equal {num1}");
            }

            ReadKey();
        }
    }
}
