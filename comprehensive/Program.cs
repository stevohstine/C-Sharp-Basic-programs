using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace comprehensive
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             The gravitational field of the moon is approximately 17% of that on the earth. Write a 
             program that calculate the weight of a man on the moon by a given weight on the moon. 
             weight=mg
             */
            decimal gravity =Convert.ToDecimal(1.7);
            decimal weight;
            decimal mass;
            WriteLine("Enter your mass");
            mass = Convert.ToDecimal(ReadLine());
            WriteLine($"The weight is {weight=mass*gravity}");
            ReadKey();
        }
    }
}
