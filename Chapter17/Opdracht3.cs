using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17
{
    class Opdracht3
    {
        public Opdracht3()
        {
            Console.Write("\nOpdracht 17.3: \nCreate a program that puts 25 random integers between 1 and 10000 in an array. Then all even numbers from the array must be displayed first, and then all odd numbers. \n\nPlease press a key to test the created script...");
            Console.ReadKey();
            Console.Clear();


        TRYAGAIN:
            Random rnd = new Random();

            int[] rndNumbers = new int[25];
            int[] evenNumbers = new int[rndNumbers.Length];
            int[] oddNumbers = new int[rndNumbers.Length];

            for (int i = 0; i < 25; i++)
            {
                int rndNumber = rnd.Next(1, 10001);
                //Console.WriteLine("{0}.Number: {1}", i + 1, rndNumber);
                rndNumbers[i] = rndNumber;
            }


            // x counts even numbers, y counts odd numbers
            int x = 0, y = 0;
            for (int i = 0; i < rndNumbers.Length; i++)
            {
                if (rndNumbers[i] % 2 == 0)
                {
                    evenNumbers[x] = rndNumbers[i];
                    x++;
                }
                else
                {
                    oddNumbers[y] = rndNumbers[i];
                    y++;
                }
            }


            // Output Section
            Console.WriteLine("All Numbers: {0}", string.Join(", ", rndNumbers));

            Console.WriteLine("\nEven numbers...");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("{0}.Even Number: {1}", i + 1, evenNumbers[i]);
            }
            Console.WriteLine("\nOdd numbers...");
            for (int i = 0; i < y; i++)
            {
                Console.WriteLine("{0}.Even Number: {1}", i + 1, oddNumbers[i]);
            }


            /*
            Random rnd = new Random();
            int[] rndNumbers = new int[25];
            List<int> evenNumList = new List<int>();
            List<int> oddNumList = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                int rndNumber = rnd.Next(0, 10001);
                //Console.WriteLine("{0}.Number: {1}", i + 1, rndNumber);
                rndNumbers[i] = rndNumber;
            }


            foreach(var num in rndNumbers)
            {
                if (num % 2 == 0) evenNumList.Add(num); 
                else oddNumList.Add(num);
            }


            int[] evenNumArr = evenNumList.ToArray();
            int[] oddNumArr = oddNumList.ToArray();

            // Output Section
            Console.WriteLine("All Numbers: {0}", string.Join(", ", rndNumbers));

            Console.WriteLine("\nEven numbers...");
            for (int i = 0; i < evenNumArr.Length; i++)
            {
                Console.WriteLine("{0}.Even Number: {1}", i + 1, evenNumArr[i]);
            }
            Console.WriteLine("\nOdd numbers...");
            for (int i = 0; i < oddNumArr.Length; i++)
            {
                Console.WriteLine("{0}.Even Number: {1}", i + 1, oddNumArr[i]);
            }
            */


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
            Console.WriteLine("\n\tWould you like to try script again?");
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
