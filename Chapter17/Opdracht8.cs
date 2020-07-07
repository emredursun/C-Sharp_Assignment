using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17
{
    class Opdracht8
    {
        public Opdracht8()
        {
            Console.Write(
                "\nOpdracht 17.8: " +
                "\nWrite a program that fills an array with 10 random numbers between 1 and 100. Then the list of numbers is displayed, separated by semicolons, for example 5; 56; 3; 98; 11; 45; 56; 67; 98; 23. " +
                "\nThe following information about the list of numbers is then displayed:\n" +
                "\n* the list of even numbers " +
                "\n* the list of odd numbers " +
                "\n* the highest number " +
                "\n* the lowest number " +
                "\n* the sum of the numbers " +
                "\n* the average of the numbers(with 2 decimal places)" +
                "\n\nPlease press a key to test the created script...");
            Console.ReadKey();
            Console.Clear();


        TRYAGAIN:

            Random rnd = new Random();
            int maxValue, minValue;
            int[] rndNumbers = new int[10];
            List<int> evenNumList = new List<int>();
            List<int> oddNumList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int rndNumber = rnd.Next(0, 101);
                //Console.WriteLine("{0}.Number: {1}", i + 1, rndNumber);
                rndNumbers[i] = rndNumber;
            }


            foreach (var num in rndNumbers)
            {
                if (num % 2 == 0) evenNumList.Add(num);
                else oddNumList.Add(num);
            }


            maxValue = rndNumbers.Max();
            int maxIndex = rndNumbers.ToList().IndexOf(maxValue);

            minValue = rndNumbers.Min();
            int minIndex = rndNumbers.ToList().IndexOf(minValue);

            int sum = 0; double average = 0;
            foreach (int num in rndNumbers)
            {
                sum += num;
                average = Math.Round((double)sum / rndNumbers.Length, 2);
            }

            // Output Section
            Console.WriteLine("\nAll Numbers: {0}", string.Join(", ", rndNumbers));
            Console.WriteLine("\nEven Number: {0}", string.Join(", ", evenNumList));
            Console.WriteLine("\nOdd Number: {0}", string.Join(", ", oddNumList));
            Console.WriteLine("\nHighest Number: {0} \tIndex of {0} is {1}.", maxValue, maxIndex);
            Console.WriteLine("\nLowest Number: {0} \tIndex of {0} is {1}.", minValue, minIndex);
            Console.WriteLine("\nSum of Numbers: {0}", sum);
            Console.WriteLine("\nAverage of Numbers: {0}", average);



            //int[] evenNumArr = evenNumList.ToArray();
            //int[] oddNumArr = oddNumList.ToArray();

            //Console.WriteLine("\nEven numbers...");
            //for (int i = 0; i < evenNumArr.Length; i++)
            //{
            //    Console.WriteLine("{0}.Even Number: {1}", i + 1, evenNumArr[i]);
            //}
            //Console.WriteLine("\nOdd numbers...");
            //for (int i = 0; i < oddNumArr.Length; i++)
            //{
            //    Console.WriteLine("{0}.Even Number: {1}", i + 1, oddNumArr[i]);
            //}


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
