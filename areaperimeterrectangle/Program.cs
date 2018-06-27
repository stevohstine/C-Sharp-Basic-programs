using System;
using static System.Console;

namespace areaperimeterrectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal length;
            decimal width;
            decimal perimeter;
            decimal area;
            WriteLine("Calculate area and perimeter of a circle");
            WriteLine("Enter the length");
            length = Convert.ToDecimal(ReadLine());
            WriteLine("Enter the width");
            width = Convert.ToDecimal(ReadLine());
            WriteLine($"The area is {area=length*width}");
            WriteLine($"The perimeter is {area = (length + width)*2}");
            ReadKey();

        }
    }
}
