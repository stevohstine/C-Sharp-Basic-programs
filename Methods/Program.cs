using System;
using static System.Console;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class person
    {
        private string name;
        private byte age;
        private float height;
        private byte weight;
    }

    public class post
    {
        private person person;
        private string title;
        private string description;
        private DateTime datetime;
    }
}
