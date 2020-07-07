using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17
{
    class Opdracht6
    {
        public Opdracht6()
        {
            Console.Write("\nOpdracht 17.6: \nWrite a program that displays an array in reverse order. Fill the array with 25 random numbers between 10 and 100. Also show the content of the original array in your output. \n\nPlease press a key to test the created script...");
            Console.ReadKey();
            Console.Clear();


        TRYAGAIN:

            int[] numArr = CreateNumArr();
            
            Console.WriteLine("Original Array: {0} \nOriginal array contains {1} numbers.\n", string.Join(", ", numArr), numArr.Length);

            Array.Reverse(numArr);
            Console.WriteLine("Reversed Array: {0} \nReversed array contains {1} numbers as well!", string.Join(", ", numArr), numArr.Length);

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

        private int[] CreateNumArr()
        {
            Random rnd = new Random();
            int[] numArr = new int[25];

            for (int i = 0; i < 25; i++)
            {
                int rndNum = rnd.Next(10, 101);
                numArr[i] = rndNum;
            }
            return numArr;
        }
    }

}
