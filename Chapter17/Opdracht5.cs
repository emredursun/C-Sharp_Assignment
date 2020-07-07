using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17
{
    class Opdracht5
    {
        public Opdracht5()
        {
            Console.Write("\nOpdracht 17.5: \nCreate a function that checks whether a BSN number entered by the user is a valid BSN number. You can perform the check with an ELF Test. Only with a BSN number the last number of the 9 numbers is not multiplied by 1 but by -1. Are you not familiar with the eleven test? Then look this up first. \n\nPlease press a key to test the created script...");
            Console.ReadKey();
            Console.Clear();


        TRYAGAIN:
            int userInput;
            Console.Write("Enter the BSN number to be checked: ");
            while (!(int.TryParse(Console.ReadLine(), out userInput)))
            {
                Console.Write("\nInvalid input type! BSN number consists of numbers only... ");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                Console.Write("Enter a valid BSN number to be checked: ");
            }

            string strUserInput = userInput.ToString();
            if(!(strUserInput.Length == 9))
            {
                Console.Write("\nInvalid input! BSN number consists of 9 numbers! Please try again... ");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                goto TRYAGAIN;
            }
            

            if (ValidateElfProef(strUserInput))
            {
                Console.WriteLine("\nThis is a valid BSN number.");
            }
            else
            {
                Console.WriteLine("\nThis is an invalid BSN number!");
            }



            //If user would try this Method again
            string userChoice = TryAgain();
            if (userChoice.Equals("Y"))
            {
                Console.Clear();
                goto TRYAGAIN;
            }
            else
            {
                Console.WriteLine("\nPress a button to test another assignment!");
                Console.ReadKey();
            }
        }


        public static string TryAgain()
        {
            Console.WriteLine("\n\tWould you like to test this script again?");
            Console.WriteLine("\t\t\t  =====================  ");
            Console.WriteLine("\t\t\t||                     ||");
            Console.WriteLine("\t\t\t||  (Y)es or (Q)uit    ||");
            Console.WriteLine("\t\t\t||                     ||");
            Console.WriteLine("\t\t\t  =====================  ");
            Console.Write("\n\tEnter your option: ");
            string userChoice = Console.ReadLine().ToUpper();
            return userChoice;
        }

        public static bool ValidateElfProef(int value)
        {
            int divisor = 1000000000;
            int total = 0;
            int result = value;
            for (int i = 9; i > 1; i--)
                total += i * Math.DivRem(result, divisor /= 10, out result);

            int rest;
            Math.DivRem(total, 11, out rest);

            return result == rest;
        }

        public static bool ValidateElfProef(string value)
        {
            return ValidateElfProef(Convert.ToInt32(value));
        }


        //public static bool MyValidateElfProef(string value)
        //{
        //    char[] numArry = value.ToCharArray();
        //    int total = 0;
        //    for (int i = 9; i > 1; i--)
        //    {
        //        total += numArry[9 - i] * i;
        //    }

        //    total += numArry[8] * (-1);

        //    //check if modulo 11 works
        //    if (total % 11 == 0) return true;
        //    else return false;
            
        //}
    }

}
