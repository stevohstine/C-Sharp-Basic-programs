using System;
using static  System.Console;

namespace conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 4;
            var b = 5;
            bool isTrue = b < a ? true : false;
            WriteLine(isTrue);
            ReadKey();
        }
    }
}
