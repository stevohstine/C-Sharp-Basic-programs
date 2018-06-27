using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace classanimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal
            {


                name = ReadLine(),
                gender = ReadLine(),
                age = Convert.ToInt32(ReadLine()),
                iswild = Convert.ToBoolean(ReadLine()),
                
             
            sound = ReadLine()

            };
            string animaltype = cow.iswild ==true?"domestic":"wild";
            WriteLine(cow.name);
            WriteLine(cow.gender);
            WriteLine(cow.age);
           
            WriteLine(animaltype);
            WriteLine(cow.sound);

            ReadKey();
        }
    }

    public class Animal
    {
        public string name { get; set; }
        public int age { get; set; }
        public string sound { get; set; }
        public string gender { get; set; }
        public bool iswild { get; set; }
    }
}
