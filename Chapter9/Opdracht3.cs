using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Chapter8
{
    class Opdracht3
    {
        public Opdracht3()
        {

            /*
             * Opdracht 8.3:
               Design a console application that calculates the quotient of an entered dividend and divisor. In a division, the divisor must not equal zero. First create a console application without taking this into account. What error message do you get in C #? Customize the console application. If the user enters 0 as the divisor, the text appears: “Who divides by zero is a kid!”.
           */

            GetUserInput();

            Console.ReadKey();
        }

        // Check User Input with this method
        public static void GetUserInput()
        {
            double dividend, divisor;
            try
            {
                Console.Write("\nDividend: ");
                dividend = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nDivisor: ");
                divisor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n\tQuotient: {0}", CalculateQuotient(dividend, divisor));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("================================================================");
                Console.WriteLine("Failed!");
                Console.WriteLine(ex.Message);
                Console.WriteLine("================================================================");
            }
            finally
            {
                //If user would try this Method again
                string userChoice = TryAgain();
                if (userChoice.Equals("Y"))
                {
                    Console.Clear();
                    GetUserInput();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }


        // Try Again Method, if user would try the any methods again
        public static string TryAgain()
        {
            Console.WriteLine("\n\tWould you like to try for any other examples?");
            Console.WriteLine("\t\t\t  =====================  ");
            Console.WriteLine("\t\t\t||                     ||");
            Console.WriteLine("\t\t\t||  (Y)es or (Q)uit    ||");
            Console.WriteLine("\t\t\t||                     ||");
            Console.WriteLine("\t\t\t  =====================  ");
            Console.Write("\n\tEnter your option: ");
            string userChoice = Console.ReadLine().ToUpper();
            return userChoice;
        }


        public static double CalculateQuotient(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentException("Who divides by zero is a kid!", "In a division, the divisor must not equal zero!");
            }
            else
            {
                double quotient = dividend / divisor;
                return quotient;
            }
        }
    }

}
