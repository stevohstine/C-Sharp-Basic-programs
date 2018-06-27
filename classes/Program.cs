using System;
using static  System.Console;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person victor=new Person(); //victor is an object .. instance of the class person.
            Person joy  = new Person();
            Person eric = new Person();

            victor.Age = 20;
            victor.Weight = 67.87;
            victor.gender = "female";
            victor.height = 5;
            victor.name = "Victor";

            Person stine = new Person
            {
                Age=21, Weight = 43.45,gender ="male", height = 5, name = "stine"
            };
            WriteLine(stine.name);

            WriteLine(victor.Age);

            ReadKey();
        }
        
        
    }
    public class Person
    {
        public int Age { get; set; }
        public double Weight { get; set; }
        public string gender { get; set; }
        public int height { get; set; }
        public string name { get; set; }
    }
}
