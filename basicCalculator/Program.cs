using System;
using static System.Console;
using static System.Math;

namespace basicCalculator

{
    class Program
    {
        static void Main()
        {
            double answer;
            int choice;
            double input1;
            double input2;
            
            for (;;)
            {
                    WriteLine(" ");
                    WriteLine(" ***************************");
                    WriteLine(" *                         *");
                    WriteLine(" *    1: Addition          *");
                    WriteLine(" *    2: subtraction       *");
                    WriteLine(" *    3: Multiplication    *");
                    WriteLine(" *    4: Division          *");
                    WriteLine(" *    5: Modulus           *");
                    WriteLine(" *    6: Cosine            *");
                    WriteLine(" *    7: Sine              *");
                    WriteLine(" *    8: Tangent           *");
                    WriteLine(" *                         *");
                    WriteLine(" *    0: EXIT              *");
                    WriteLine(" *                         *");
                    WriteLine(" ***************************");
                    WriteLine("  Enter your choice");
                    choice = Convert.ToInt32(ReadLine());
                    Clear();


            switch (choice)
            {
                case 1:
                        WriteLine("Enter two numbers to add");
                        WriteLine("Enter first number");
                        input1 = Convert.ToDouble(ReadLine());
                        WriteLine("Enter second number");
                        input2 = Convert.ToDouble(ReadLine());
                        WriteLine($"Answer is: {answer =input1 + input2}");
                        WriteLine("Press any key to do another calculation");
                        ReadKey();
                        Clear();
                        break;
                    case 2:
                        WriteLine("Enter two numbers to subtract");
                        WriteLine("Enter first number");
                        input1 = Convert.ToDouble(ReadLine());
                        WriteLine("Enter second number");
                        input2 = Convert.ToDouble(ReadLine());
                        WriteLine($"Answer is: {answer = input1 - input2}");
                        WriteLine("Press any key to do another calculation");
                        ReadKey();
                        Clear();
                        break;
                    case 3:
                        WriteLine("Enter two numbers to multiply");
                        WriteLine("Enter first number");
                        input1 = Convert.ToDouble(ReadLine());
                        WriteLine("Enter second number");
                        input2 = Convert.ToDouble(ReadLine());
                        WriteLine($"Answer is: {answer = input1 * input2}");
                        WriteLine("Press any key to do another calculation");
                        ReadKey();
                        Clear();
                        break;
                    case 4:
                        WriteLine("Enter two numbers to divide");
                        WriteLine("Enter first number");
                        input1 = Convert.ToDouble(ReadLine());
                        WriteLine("Enter second number");
                        input2 = Convert.ToDouble(ReadLine());
                        WriteLine($"Answer is: {answer = input1 / input2}");
                        WriteLine("Press any key to do another calculation");
                        ReadKey();
                        Clear();
                        break;
                    case 5:
                        WriteLine("Enter two numbers to find the remainder");
                        WriteLine("Enter first number");
                        input1 = Convert.ToDouble(ReadLine());
                        WriteLine("Enter second number");
                        input2 = Convert.ToDouble(ReadLine());
                        WriteLine($"Answer is: {answer = input1 % input2}");
                        WriteLine("Press any key to do another calculation");
                        ReadKey();
                        Clear();
                        break;
                    case 6:
                        WriteLine("Enter number to find the cosine");
                        input1 = Convert.ToDouble(ReadLine());
                        answer = Cos(input1);
                        WriteLine(answer);
                        WriteLine("Press any key to do another calculation");
                        ReadKey();
                        Clear();
                        break;
                case 7:
                    WriteLine("Enter number to find the sine");
                    input1 = Convert.ToDouble(ReadLine());
                    answer = Sin(input1);
                    WriteLine(answer);
                    WriteLine("Press any key to do another calculation");
                    ReadKey();
                    Clear();
                    break;
                case 8:
                    WriteLine("Enter number to find the tangent");
                    input1 = Convert.ToDouble(ReadLine());
                    answer = Tan(input1);
                    WriteLine(answer);
                    WriteLine("Press any key to do another calculation");
                    ReadKey();
                    Clear();
                    break;
                    default:
                        WriteLine("INVALID CHOICE!!!");
                        WriteLine("TRY AGAIN");
                        break;
                }

                if (choice==0)
                {
                  break;  
                }
            }
         
        }
    }
}
