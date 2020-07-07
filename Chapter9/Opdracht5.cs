using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8
{
    class Opdracht5
    {
        static Random r = new Random();
        public Opdracht5()
        {

            /*
             * Opdracht 8.5:
                The program should choose 2 random numbers 100 times, after which the product of both numbers is displayed. Detect all errors in the program and make sure it works properly (you can no negative numbers appear).
           */

            GetRandomNumbers();


            Console.ReadKey();
        }

        // Check User Input with this method
        public static void GetRandomNumbers()
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    int getal1 = r.Next(int.MinValue, int.MaxValue);
                    int getal2 = r.Next(int.MinValue, int.MaxValue);
                    int product = getal1 * getal2;

                    if (getal1 < 0 || getal2 < 0)
                    {
                        product = Math.Abs(product);
                        Console.WriteLine("This product has been Abst! We don't want negativity in our productline.");
                        Console.WriteLine($"{getal1} * {getal2} = {product}");
                    }
                    else if (product < 0)
                    {
                        Console.WriteLine($"{getal1} * {getal2} : This product does not follow normal arithmetic-rules. I'm too ashamed to show it");
                    }
                    else
                    {
                        Console.WriteLine($"{getal1} * {getal2} = {product}");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("==========================================================");
                Console.WriteLine("Failed!");
                Console.WriteLine(ex.Message);
                Console.WriteLine("==========================================================");
            }
            finally
            {
                //If user would try this Method again
                string userChoice = TryAgain();
                if (userChoice.Equals("Y"))
                {
                    Console.Clear();
                    GetRandomNumbers();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }


        // Try Again Method, if user would try the any methods again
        public static string TryAgain()
        {
            Console.WriteLine("\n\tWould you like to try for any other examples?");
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
