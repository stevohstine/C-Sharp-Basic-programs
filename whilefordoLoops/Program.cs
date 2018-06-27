using System;
using static System.Console;

namespace whilefordoLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int x = 0;
            int b = 0;
            for (a = 0; a <= 10; a++)
            {
                WriteLine(a);
            }

            while (x<=10)
            {
               WriteLine(x);
                x++;
            }

            do
            {
              WriteLine(b);
                b++;
            } while (b<=10);

            ReadKey();
        }
    }
}
