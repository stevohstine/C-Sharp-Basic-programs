using System;
using static System.Console;

namespace ordercoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            string coffeetype;
            int cups;
            decimal price = 50;
            DateTime date;
            decimal total;

            WriteLine("What type of coffee do you want?");
            coffeetype = ReadLine();
            WriteLine("How many cups do you want?");
            cups = Convert.ToInt32(ReadLine());
            total = cups * price;
            date = DateTime.Now;
            Clear();

            WriteLine("You ordered" + " " + coffeetype);
            WriteLine(cups + " " + "cups");
            WriteLine(Convert.ToDateTime(date));
            WriteLine("The total is" + " " + total);
            WriteLine("Thankyou for drinking with us");
            WriteLine("You were served by: Stephen");
            ReadKey();

        }
    }
}

