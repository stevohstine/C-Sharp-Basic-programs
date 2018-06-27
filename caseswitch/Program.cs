using System;
using static System.Console;

namespace caseswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Prints number 1 to 5");
            var a = 1;
            switch (a)
            {
                case 1:
                    WriteLine("one");
                    goto case 2;
                case 2:
                    WriteLine("Two");
                    goto case 3;
                case 3:
                    while (true)
                    {
                        WriteLine("others");
                    }
                    default:
                        WriteLine("dont know");
                        break;
                        
                
            }
        }
    }
}
