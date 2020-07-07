using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Chapter8
{
    class Opdracht2
    {
        public Opdracht2()
        {

            /*
             * Opdracht 8.2:
                Have the user enter a date (specify how you want the date to be entered, for example, YYYY-MM-DD or DD-MM-YYYY or MM-DD-YYYY) and show how many days there are in that month. Take leap years into account and ensure that your acceptance test also tests on February 29. Make sure the application does not crash if an invalid date is entered.
           */

            CheckUserInput();

            Console.ReadKey();
        }

        // Check User Input with this method
        public static bool CheckUserInput()
        {
            Console.Write("\nEnter a date(DD-MM-YYYY): ");
            DateTime userInput;
            try
            {
                userInput = DateTime.Parse(Console.ReadLine());
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(userInput.Month);
                Console.WriteLine("============================================");
                IsLeapYear(userInput.Year);
                Console.WriteLine("There are {0} days in {1}, {2}.", DaysInMonth(userInput.Year, userInput.Month, userInput.Day), monthName, userInput.Year);
                Console.WriteLine("============================================");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("=================================================================================");
                Console.WriteLine("Failed! You must enter the date according to the following format => (DD-MM-YYYY)");
                Console.WriteLine(ex.Message);
                Console.WriteLine("=================================================================================");
                return false;
            }
            finally
            {
                //If user would try this Method again
                string userChoice = TryAgain();
                if (userChoice.Equals("Y"))
                {
                    Console.Clear();
                    CheckUserInput();
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


        // To calculate the number of days in a month according to an entered date
        public static int DaysInMonth(int year, int month, int day)
        {
            int numOfDays = System.DateTime.DaysInMonth(year, month);
            return numOfDays;
        }

        // To determine the entered year a Leap year or NOT
        public static void IsLeapYear(int year)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a Leap Year!");
                //return true;
            }
            else
            {
                Console.WriteLine($"{year} is NOT a Leap Year!");
                //return false;
            }
        }
    }

}
