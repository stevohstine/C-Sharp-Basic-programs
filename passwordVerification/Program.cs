using System;
using static System.Console;

namespace passwordVerification
{
    class Program
    {
        static void Main(string[] args)
        {
            int password=12345;
            int pass;
            int trial;
           
            for (trial=1;trial<=3;trial++)
            {
                
                WriteLine("Enter your password");
                pass = Convert.ToInt32(ReadLine());
                if (pass == password)
                {
                    WriteLine("Password correct");
                    WriteLine("Welcome to Dkut");
                    break;
                }
                else if(pass!=password)
                {
                    WriteLine(" Incorrect password!!!! Try again!!");
                  continue;  
                }   
            }

            ReadKey();


        }
    }
}
