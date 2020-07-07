using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17
{
    class Opdracht9
    {
        public Opdracht9()
        {
            Console.Write(
                "\nOpdracht 17.9: " +
                "\nMake a program with 2 arrays of 10 random numbers each, between 10 and 99. As output show the numbers from both arrays and below that the sum of the numbers from the arrays. Make sure everything is neatly lined up. " +
                "\nFor example: \n" +
                "\n* Array 1: 12 19 88 74 32 11 90 54 32 65" +
                "\n* Array 2: 23 21 43 66 87 12 40 24 10 99" +
                "\n* Som: 35 40 131 140 119 23 130 78 42 164" +
                "\n\nNumbers can occur multiple times in an array." +
                "\n\nPlease press a key to test the created script...");
            Console.ReadKey();
            Console.Clear();


        TRYAGAIN:

            Random rnd = new Random();
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] sum = new int[10];


            for (int i = 0; i < 10; i++)
            {
                int rndNum1 = rnd.Next(10, 100);
                int rndNum2 = rnd.Next(10, 100);
                array1[i] = rndNum1;
                array2[i] = rndNum2;
                sum[i] = rndNum1 + rndNum2;
            }


            // Output for First Method
            Console.WriteLine("First Method:");
            Console.WriteLine("\nArray 1: {0}", string.Join(" ", array1));
            Console.WriteLine("\nArray 2: {0}", string.Join(" ", array2));
            Console.WriteLine("\nSum:\t{0}", string.Join(" ", sum));


            // Output for second Method
            Console.WriteLine("\nsecond Method: \n");

            Console.Write("Array 1: ");
            foreach (int num in array1)
            {
                Console.Write("\t{0}", num);
            }

            Console.WriteLine();
            Console.Write("Array 2: ");
            foreach (int num in array2)
            {
                Console.Write("\t{0}", num);
            }
            
            Console.WriteLine();
            Console.Write("Sum:    ");
            foreach (int num in sum)
            {
                Console.Write("\t{0}", num);
            }


            #region Third Method
            // Second Method with 2 dimension Array
            Console.WriteLine("\n\n\nThird Method: \n");

            int[,] mainArr = new int[3, 10];

            // Create the first 2 rows of 3 dimension array each row has a capacity of 10 numbers
            for (int row = 0; row < 2; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    int rndNum = rnd.Next(10, 100);
                    mainArr[row, column] = rndNum;
                }
            }

            // Find Sum of Array1 and Array2
            for (int column = 0; column < 10; column++)
            {
                mainArr[2, column] = mainArr[0, column] + mainArr[1, column];
            }

            // This method helps to Console 2.dimension array
            Print2DArray(mainArr);
            #endregion



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
            // Move cursor 2 lines down
            Console.CursorTop = Console.CursorTop + 2;
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
