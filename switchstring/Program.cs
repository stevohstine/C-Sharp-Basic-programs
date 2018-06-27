using System;
using static System.Console;

namespace switchstring
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek day;
            day = DayOfWeek.Sunday;
            string input;
            WriteLine("Enter a day");
            input =(ReadLine());
            input=input.ToLower();
            if (input== "monday")
            {
                day = DayOfWeek.Monday;
            }
            else if(input=="tuesday")
            {
                day = DayOfWeek.Tuesday;
            }
            else if (input=="wednesday")
            {
                day = DayOfWeek.Wednesday;
            }
            else if (input=="thursday")
            {
                day = DayOfWeek.Thursday;
            }
           else if (input == "friday")
            {
                day = DayOfWeek.Friday;
            }
            else if (input == "saturday")
            {
                day = DayOfWeek.Saturday;
            }
            switch (day)
            {
                case DayOfWeek.Monday:
                    WriteLine("monday");
                    break;
                case DayOfWeek.Tuesday:
                    WriteLine("tuesday");
                    break;
                case DayOfWeek.Wednesday:
                    WriteLine("wednesday");
                    break;
                case DayOfWeek.Thursday:
                    WriteLine("thursday");
                    break;
                case DayOfWeek.Friday:
                    WriteLine("friday");
                    break;
                case DayOfWeek.Saturday:
                    WriteLine("saturday");
                    break;
                default:
                    WriteLine("not in list");
                    break;
            }

            ReadKey();
        }
    }
}
