using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Opdracht1
    {
        public Opdracht1()
        {
            /*
             * Opdracht 5.1:
               Maak een programma dat de gebruiker vraagt naar de volgende gegevens:
               • Voornaam
               • Tussenvoegsels
               • Achternaam
               Vervolgens moet worden weergegeven wat de totale lengte van de naam is. Spaties moeten niet
               worden meegeteld.
           */
            
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your second name: ");
            string secondName = Console.ReadLine();
            Console.WriteLine("Enter your surname: ");
            string surName = Console.ReadLine();

            string userNameBox = firstName + secondName + surName;

            int count = 0;
            //Counts each character except space  
            for (int i = 0; i < userNameBox.Length; i++)
            {
                if (userNameBox[i] != ' ')
                    count++;
            }

            //Displays the total number of characters present in the given string  
            //Console.WriteLine("Total number of characters in your full name: " + count);
            Console.WriteLine($"Your full name consists of '{count}' characters without spaces!");


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
