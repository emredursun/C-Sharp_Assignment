using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17
{
    class Opdracht2
    {
        public Opdracht2()
        {
            Console.Write("\nOpdracht 17.2: \nCreate an array with all the names of the members of your group and then randomly display one of the names. \n\nPlease press a key to test the created script..."); 
            Console.ReadKey();
            Console.Clear();


        TRYAGAIN:
            string[] groupMembers = {"Jurre", "Willem", "Sander", "Karaal", "Emre"};
            Random rnd = new Random();
            int rndMember = rnd.Next(0,5);

            Console.WriteLine("Output: \n\t{0}.Member: {1}", rndMember + 1, groupMembers[rndMember]);
            
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
