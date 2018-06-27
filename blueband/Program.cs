using System;
using static System.Console;

namespace blueband
{
    class Program
    {
        static void Main(string[] args)
        {
            var blueband = Convert.ToDateTime("02/07/2018");
            var delmonte = Convert.ToDateTime("08/08/2018");
            var bisquits = Convert.ToDateTime("05/05/2018");
            var others = Convert.ToDateTime("07/06/2018");
            WriteLine("Input an item");
            var input= ReadLine(); 
            input = input.ToLower();
            switch (input)
            {
                case "blueband":
                WriteLine($"Expirery date of blueband {blueband}");
                break;
                case "delmonte":
                WriteLine($"Expirery date for delmonte is {delmonte}");
                break;
                case "bisquits":
                WriteLine($"Expirely date for bisquits is {bisquits}");
                break;
                case "others":
                WriteLine($"Expirely date for others is {others}");
                break;
                default:
                WriteLine("Item not in list");
                break;
            }

            ReadKey();
        }
    }
}
