using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17
{
    class Opdracht1
    {
        public Opdracht1()
        {

            /*
             * Opdracht 17.1:
                Ask the user to enter 5 numbers and store the numbers in an array. Then display the entered numbers as follows:
                The first number is:…
                The second number is:…
           */

            Console.Write("\nOpdracht 17.1: \nAsk the user to enter 5 numbers and store the numbers in an array. Then display the entered numbers as follows: \nThe first number is:…\nThe second number is:…\n\nPlease press a key to test the created script...");
            Console.ReadKey();
            Console.Clear();

            // Input Section
            int[] numbers = new int[5];
            int userInput;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.Write("{0}.Number: ", i+1);
                while (!(int.TryParse(Console.ReadLine(), out userInput)))
                {
                    Console.Write("\nInvalid input type! Try again. Please enter a number... ");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    Console.Write("{0}.Number: ", i + 1);
                }
                numbers[i] = userInput;
            }

            // Output Section
            Console.Clear();
            Console.WriteLine("Your all inputs are: \n");
            for (int i = 1; i <= numbers.Length; i++)
            {
                Console.WriteLine("{0}.Number: {1}", i, numbers[i-1]);
            }

            Console.WriteLine("\nPress a button to test another assignment!");
            Console.ReadKey();
        }
    }

}
