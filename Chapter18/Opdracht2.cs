using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter18
{
    class Opdracht2
    {
        public Opdracht2()
        {

            Console.Write("\nOpdracht 18.2: " +
               "\nCreate a 2D array of 15 rows and 15 columns. Each cell must be filled with a random test digit from 1 to 10 with exactly 1 decimal. " +
               "\nAll figures should be presented as a table and below the table should be the average of all figures. " +
               "\n\nPlease press a key to test the created script...");
            Console.ReadKey();
            Console.Clear();


            
        TRYAGAIN:
            // Input Section
            // This method helps about getting info about number of people 
            string rowLengthQ = "Determine the row-length of your array";
            string colLengthQ = "Determine the column-length of your array";
            int rowLength = DetermineSizeOfArr(rowLengthQ);
            int colLength = DetermineSizeOfArr(colLengthQ);
            Random rnd = new Random();

            int[,] numArray = new int[rowLength, colLength];

            // Create the Array
            for (int i = 0; i < numArray.GetLength(0); i++)
            {
                for (int j = 0; j < numArray.GetLength(1); j++)
                {
                    int rndNum = rnd.Next(1, 10);
                    numArray[i, j] = rndNum;
                }
            }

            // Output Section
            Console.Clear();
            Console.WriteLine($"Output for 2D int[{rowLength},{colLength}] Array:\n");
            Print2DArray(numArray); // As Array


            //If user would try this Method again
            string userChoice = TryAgain();
            if (userChoice.Equals("Y"))
            {
                Console.Clear();
                goto TRYAGAIN;
            }
            else
            {
                Console.Write("\nPress a button to test another assignment... ");
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


        public static int DetermineSizeOfArr(string inputQuestion)
        {
            int numOfMembers = 0;
            Console.Clear();
            Console.Write($"{inputQuestion} : ");
            while (!(int.TryParse(Console.ReadLine(), out numOfMembers)))
            {
                Console.Write("\nInvalid input type! Try again. Please enter a number... ");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                Console.Write($"{inputQuestion} : ");
            }
            return numOfMembers;
        }


        public static void Print2DArray<T>(T[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("\t{0} ", matrix[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }

}
