using System;
using static System.Console;

namespace coalenceoperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = null;
            string two = null;
            string three = "three";
            string result = three ?? two ?? one;
            WriteLine(result);
            ReadKey();
        }
    }
}
