using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8
{
    class Opdracht1
    {
        public Opdracht1()
        {

            /*
             * Opdracht 8.1:
                Write a function that checks whether the user's input is a number. Is it a number then it show word 'number' otherwise 'error' on the screen.
           */

            CheckUserInput();

            Console.ReadKey();
        }

        // Check User Input with this method
        public static bool CheckUserInput()
        {
            Console.Write("\nInput: ");
            double userInput;
            try
            {
                userInput = double.Parse(Console.ReadLine());
                Console.WriteLine("=========================================================");
                Console.WriteLine("Success! Your input: {0} that is a right input type!", userInput);
                Console.WriteLine("=========================================================");
                return true;
            }
            catch (FormatException e)
            {
                Console.WriteLine("==========================================================");
                Console.WriteLine("Failed! Expected a number.");
                Console.WriteLine(e.Message);
                Console.WriteLine("==========================================================");
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
    }

}
