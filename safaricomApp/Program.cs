using System;
using static System.Console;

namespace safaricomApp
{
    class Program
    {
        static void Main()
        {
            
            int choice;
            int loop = 0;
            for (loop = 0; loop <= 1000; loop++)
            {
                WriteLine(" ");
                
                WriteLine(" ******************************");
                WriteLine(" *                            *");
                WriteLine(" *    Self care:              *");
                WriteLine(" *    0: Flex                 *");
                WriteLine(" *    1: My Account           *");
                WriteLine(" *    2: Buy Data Bundles     *");
                WriteLine(" *    3: Products & Services  *");
                WriteLine(" *    4: Mpesa                *");
                WriteLine(" *    5: My Subscriptions     *");
                WriteLine(" *    6: Advantage Plus       *");
                WriteLine(" *    7: Stori Ibambe         *");
                WriteLine(" *    8: Get your PUK Number  *");
                WriteLine(" *    98: MORE                *");
                WriteLine(" *                            *");
                WriteLine(" *    10: EXIT                *");
                WriteLine(" *                            *");
                WriteLine(" ******************************");


                WriteLine(" Enter your choice:");
                choice = Convert.ToInt32(ReadLine());
                Clear();
                switch (choice)
                {
                    case 0:
                        WriteLine("1: Sh999: 1,100 Flex for 30 days");
                        WriteLine("2: Sh1499: 1,700 Flex for 30 days");
                        WriteLine("3: Sh2499: 3,500 Flex for 30 days");
                        WriteLine("4: Daily Flex Bundles");
                        WriteLine("5: 7 day Flex Bundles");
                        WriteLine("98:MORE");
                        choice = Convert.ToInt32(ReadLine());
                        Clear();
                        break;
                    case 1:
                        WriteLine("welcome1");
                        choice = Convert.ToInt32(ReadLine());
                        Clear();
                        break;
                    case 2:
                        WriteLine("welcome2");
                        choice = Convert.ToInt32(ReadLine());
                        Clear();
                        break;
                    case 10:
                        WriteLine("Press any key to end program");
                        break;
                    default:
                        Clear();
                        WriteLine("Invalid choice!!!!!!!");
                        break;
                }

                if (choice == 10)
                {
                    break;
                }

                
                //second switch
                switch (choice)
                {
                    case 1:
                        WriteLine("Get 1,100 Monthly Flex @sh999");
                        WriteLine("1: Buy Once");
                        WriteLine("2: Auto-Renew");
                        choice = Convert.ToInt32(ReadLine());
                        break;
                    case 2:
                        WriteLine("Get 1,700 Monthly Flex @sh1499");
                        WriteLine("1: Buy Once");
                        WriteLine("2: Auto-Renew");
                        choice = Convert.ToInt32(ReadLine());
                        break;
                    case 3:
                        WriteLine("Get 3,500 Monthly Flex @sh2499");
                        WriteLine("1: Buy Once");
                        WriteLine("2: Auto-Renew");
                        choice = Convert.ToInt32(ReadLine());
                        break;
                    case 4:
                        WriteLine("Daily Flex bundles");
                        WriteLine("1:Sh99: 115 Flex daily");
                        WriteLine("2:Sh50: 50 Flex daily");
                        WriteLine("0: BACK");
                        choice = Convert.ToInt32(ReadLine());
                        break;
                    case 5:
                        WriteLine("7 day Flex bundles");
                        WriteLine("1:Sh599: 700 Flex for 7 days");
                        WriteLine("0: BACK");
                        choice = Convert.ToInt32(ReadLine());
                        break;
                    case 98:
                        WriteLine("6: 30 day Flex Bundles");
                        WriteLine("7: Stop Autorenew");
                        WriteLine("8: Buy for other Number");
                        WriteLine("9: Check Flex Balance");
                        WriteLine("10: FAQs");
                        WriteLine("0: BACK");
                        choice = Convert.ToInt32(ReadLine());
                        break;
                    default:
                        Clear();
                        WriteLine("Invalid choice!!!!!!!");
                        break;
                }
            }

            ReadKey();

        }
    }
}
