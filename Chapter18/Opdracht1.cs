using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter18
{
    class Opdracht1
    {
        public Opdracht1()
        {
            Console.Write("\nOpdracht 18.1: " +
                "\nCreate a 2D array containing the following information from the members of your group: " +
                "\n* Student number " +
                "\n* First Name " +
                "\n* Last name " +
                "\n* Date of birth " +
                "\n* Birthplace " +
                "\nAll information must be shown on the screen as follows (example): " +
                "\nJan Boswinkel (0234567) was born on March 12, 1998 in Hengelo. " +
                "\nGerrit de Vries (0123456) was born on December 31, 1999 in Borne etc." +
                "\n\nPlease press a key to test the created script...");
            Console.ReadKey();
            Console.Clear();


        // Input Section
        TRYAGAIN:
            // This method helps about getting info about number of people 
            int numOfMembers = GetNumOfMembers();


            string[] questionsArr = new string[] 
            {
                "Student Number",
                "First Name",
                "Last name",
                "Date of Birth",
                "Birthplace"
            };

            string[,] groupInfo = new string[numOfMembers, 5];

            // Dinamik User input Loop
            string userInput;
            for (int i = 0; i < groupInfo.GetLength(0); i++)
            {
                for (int j = 0; j < groupInfo.GetLength(1); j++)
                {
                    userInput = GetUserInput(questionsArr[j]);
                    groupInfo[i,j] = userInput;
                }
            }

            // Output Section
            PrintGroupInfo(groupInfo); // As string
            //Print2DArray(groupInfo); // As Array


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

        public static string GetUserInput(string inputQuestion)
        {
            var userInput = "";
            do
            {
                Console.Clear();
                Console.WriteLine("{0}: ", inputQuestion);
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

        public static void Print2DArray<T>(T[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        public static void PrintGroupInfo<T>(T[,] groupInfo)
        {
            Console.Clear();
            int rowLength = groupInfo.GetLength(0);
            int colLength = groupInfo.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                Console.WriteLine($"{groupInfo[i, 1]} {groupInfo[i, 2]} ({groupInfo[i, 0]}) was born on {groupInfo[i, 3]} in {groupInfo[i, 4]}.");
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
    }

}
