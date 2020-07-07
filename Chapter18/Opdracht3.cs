using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter18
{
    class Opdracht3
    {
        public Opdracht3()
        {

            Console.Write("\nOpdracht 18.3: " +
               "\nCreate an application that requires the following information from your group members: " +
               "\n* Name " +
               "\n* Grade for Math " +
               "\n* Grade for Dutch " +
               "\n* Grade for English " +
               "\n\nThe names must be stored in a 1D array and the numbers in a 2D array. " +
               "\nThe result should be that a report is printed for all students (grades below 5.5 should be displayed in red): " +
               "\n\nPlease press a key to test the created script...");
            Console.ReadKey();
            Console.Clear();

        // Input Section
        TRYAGAIN:
            // This method helps about getting info about number of people 
            int numOfMembers = GetNumOfMembers();
            string[] inputQuestions = new string[]
            {
                "Full Name",
                "Grade for Math",
                "Grade for Dutch",
                "Grade for English"
            };

            int rowLength = numOfMembers;
            int colLength = inputQuestions.Length - 1;

            string[] membersNames = new string[numOfMembers];
            string[,] membersGrades = new string[rowLength, colLength];

            string userInput;
            for (int i = 0; i < rowLength; i++)
            {
                userInput = GetUserInput(inputQuestions[0]);
                membersNames[i] = userInput;
                for (int j = 0; j < colLength; j++)
                {
                    userInput = GetUserInput(inputQuestions[j+1]);
                    membersGrades[i, j] = userInput;
                }
            }

            // Output Section
            Console.Clear();
            //Console.WriteLine("\nMembers:");
            //Print1DArray(membersNames); // As 1D Array
            //Console.WriteLine("\nGrades of Members:");
            //Print2DArray(membersGrades); // As 2D Array

            // Print Report
            PrintReport(membersNames, membersGrades);


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


        public static void Print1DArray<T>(T[] matrix)
        {
            // Move cursor 2 lines down
            Console.CursorTop = Console.CursorTop + 1;

            foreach (T item in matrix)
            {
                Console.WriteLine("\t{0}", item);
            }
        }

        public static void Print2DArray<T>(T[,] matrix)
        {
            // Move cursor 2 lines down
            Console.CursorTop = Console.CursorTop + 1;

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


        public static int GetNumOfMembers()
        {
            int numOfMembers = 0;
            Console.Write("How many member's information you want to save in the system: ");
            while (!(int.TryParse(Console.ReadLine(), out numOfMembers)))
            {
                Console.Write("\nInvalid input type! Try again. Please enter a number... ");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                Console.Write("How many member's information you want to save in the system: ");
            }
            return numOfMembers;
        }

        public static string GetUserInput(string inputQuestion)
        {
            var userInput = "";
            do
            {
                Console.Clear();
                Console.WriteLine(" \n{0}: ", inputQuestion);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("".PadRight(80, '*'));
                Console.WriteLine("* Input:" + "".PadRight(71, ' ') + "*");
                Console.WriteLine("".PadRight(80, '*'));
                Console.ResetColor();
                Console.CursorLeft = 9;
                Console.CursorTop = Console.CursorTop - 2;
                userInput = Console.ReadLine();
            } while (userInput.Length < 1 || userInput.Length > 70);
            return userInput;
        }

        public static void PrintReport<T>(T[] matrix1D, T[,] matrix2D)
        {
            int length1D = matrix1D.Length;
            int rowLength = matrix2D.GetLength(0);
            int colLength = matrix2D.GetLength(1);

            string[] lessons = new string[] {"Math   ", "Dutch  ", "English"};
            double[] avrg = new double[colLength];

            
            for (int i = 0; i < rowLength; i++)
            {
                int sum = 0;
                Console.WriteLine("{0}:\n", matrix1D[i]);
                for (int j = 0; j < colLength; j++)
                {
                    sum += Convert.ToInt32(matrix2D[i,j]);
                    avrg[i] = Math.Round((double)sum / colLength, 1);
                    if(Convert.ToInt32(matrix2D[i, j]) < 55)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(string.Format("\t{0}\t: {1}", lessons[j], matrix2D[i, j]));
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(string.Format("\t{0}\t: {1}", lessons[j], matrix2D[i, j]));
                    }
                }
                Console.WriteLine(string.Format("\tAverage\t: {0}", avrg[i]));
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }

}
