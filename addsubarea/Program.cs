using System;
using static System.Console;

namespace addsubarea
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.142f, area, radius;
            WriteLine("Program to calculate area of a circle");
            WriteLine("Enter the radius:");
            radius = Convert.ToInt32(ReadLine());
            area = pi * radius * radius;
            Clear();
            WriteLine("The area is: {0} ", area);
            ReadKey();
        }
    }
}
