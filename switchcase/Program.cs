using System;
using System.Diagnostics;
using static System.Console;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            WriteLine("Enter a number;");
            a = Convert.ToInt32(ReadLine());
            switch (a)
            {
                case 1:
                    WriteLine("You number is 1");
                    break;
                case 2:
                    WriteLine("Your number is 2");
                    break;
                case 3:
                    WriteLine("Your number is 3");
                    break;
                case 4:
                    WriteLine("your number i 4");
                    break;
                case 5:
                    WriteLine("your number is 5");
                    break;
                case 6:
                    WriteLine("your number is 6");
                    break;
                case 7:
                    WriteLine("your number is 7");
                    break;
                case 8:
                    WriteLine("your number is 8");
                    break;
                case 9:
                    WriteLine("your number is 9");
                    break;
                case 10:
                    WriteLine("your number is 10");
                    break;
                default:
                    WriteLine("Your number is not in range");
                    break;

            }

            ReadKey();

            
            {

            }
        }
    }
}
