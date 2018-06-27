using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace trapeziu
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a, b, c, area;
            WriteLine("Enter width");
            a = Convert.ToDecimal(ReadLine());
            WriteLine("Enter base");
            b = Convert.ToDecimal(ReadLine());
            WriteLine("Enter height");
            c = Convert.ToDecimal(ReadLine());
            WriteLine($"The area of the trapezium {area = (a + b) * c / 2}");
            ReadKey();
        }
    }
}
