using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter18
{
    class Opdracht4
    {
        public Opdracht4()
        {
            Console.Write("\nOpdracht 18.4: " +
                "\nCreate an application that asks the user how many columns and how many rows to see (maximum 20 columns and maximum 50 rows). Then a table should be shown with the dimensions of the user's input with a random number between 1 (inclusive) and 10 (exclusive) in each cell. All even numbers must be shown in red with a yellow background and all odd numbers in yellow with a red background. " +
                "\n\nPlease press a key to test the created script...");
            Console.ReadKey();
            Console.Clear();


        // Input Section
        TRYAGAIN1:
            string inputQ1 = "Enter the number of rows for your table(Max <= 50): ";
            int numOfRow = GetUserInput(inputQ1);
            if (numOfRow > 50) 
            {
                Console.Write("Wrong input! You can not add more than 50 rows to your table, please try again...");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                goto TRYAGAIN1;
            }

        TRYAGAIN2:
            string inputQ2 = "Enter the number of columns for your table(Max <= 20): ";
            int numOfCol = GetUserInput(inputQ2);
            if (numOfCol > 20)
            {
                Console.Write("Wrong input! You can not add more than 20 columns to your table, please try again...");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                goto TRYAGAIN2;
            }


            Random rnd = new Random();
            int[,] userTable = new int[numOfRow, numOfCol];

            
            for (int i = 0; i < userTable.GetLength(0); i++)
            {
                for (int j = 0; j < userTable.GetLength(1); j++)
                {
                    userTable[i, j] = rnd.Next(1, 10);
                }
            }


            // Output Section
            Console.Clear();
            for (int i = 0; i < userTable.GetLength(0); i++)
            {
                Console.Write(Environment.NewLine);
                for (int j = 0; j < userTable.GetLength(1); j++)
                {
                    int value = userTable[i, j];
                    if (value % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(string.Format("\t{0}\t", value));
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(string.Format("\t{0}\t", value));
                        Console.ResetColor();
                    }
                }
                Console.Write(Environment.NewLine);
            }

            //If user would try this Method again
            string userChoice = TryAgain();
            if (userChoice.Equals("Y"))
            {
                Console.Clear();
                goto TRYAGAIN1;
            }
            else
            {
                Console.Write("\nPress a button to test another assignment... ");
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

        

        public static int GetUserInput(string inputQuestion)
        {
            int userInput = 0;
            Console.Clear();
            Console.Write(inputQuestion);
            while (!(int.TryParse(Console.ReadLine(), out userInput)))
            {
                Console.Write("\nInvalid input type! Try again. Please enter a number... ");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                Console.Write(inputQuestion);
            }
            return userInput;
        }
    }

}
