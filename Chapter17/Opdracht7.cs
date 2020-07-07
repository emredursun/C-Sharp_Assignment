using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17
{
    class Opdracht7
    {
        public Opdracht7()
        {
            Console.Write("\nOpdracht 17.7: \nWrite a program that calculates the sum of all numbers in an array. First let the user enter 10 digits and as a result the sum must be displayed. Create a separate Sum Array function for calculating the sum. \n\nPlease press a key to test the created script...");
            Console.ReadKey();
            Console.Clear();


        TRYAGAIN:

            // FOR LOOP
            int[] userInputs = new int[11];
            int userInput = 0, sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0}.Number: ", i);
                while (!(int.TryParse(Console.ReadLine(), out userInput)))
                {
                    Console.Write("\nInvalid input type! Try again. Please enter a number... ");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    Console.Write("{0}.Number: ", i);
                }
                userInputs[i] = userInput;
                sum = sum + userInputs[i];
                Console.Clear();
            }

            Console.WriteLine("All you inputs: {0}", string.Join(", ", userInputs));
            Console.WriteLine("\nSum: " + sum);


            //// WHILE LOOP
            //int counter = 1, num = 0, sum = 0;
            //while(counter <= 5)
            //{
            //Console.Write("{0}.Number: ", counter);
            //num = Convert.ToInt32(Console.ReadLine());
            //sum += num;
            //counter++;
            //}
            //Console.WriteLine("Sum: " + sum);
            //Console.ReadKey();


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

    }

}
