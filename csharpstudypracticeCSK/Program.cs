using System;
using static System.Console;

namespace csharpstudypracticeCSK
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname;
            string lname;
            int phoneNumber;
            decimal salary;
            decimal tax;
            DateTime date;
            BackgroundColor = ConsoleColor.DarkMagenta;
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Enter first name:");
            fname = ReadLine();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("Enter last name:");
            lname = ReadLine();
            ForegroundColor = ConsoleColor.Black;
            WriteLine("Enter phone number:");
            phoneNumber = Convert.ToInt32(ReadLine());
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Enter salary :");
            salary = Convert.ToDecimal(ReadLine());
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Enter tax :");
            tax = Convert.ToDecimal(ReadLine());
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Enter Date :");
            date = Convert.ToDateTime(ReadLine());
            Clear();

            WriteLine(fname + " " + lname);
            WriteLine(phoneNumber);
            WriteLine(salary);
            WriteLine(tax);
            WriteLine(date);

            ReadKey();
        }
    }
}
