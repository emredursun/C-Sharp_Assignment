using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht10
    {
        public Opdracht10()
        {
            /*
             * Opdracht 3.10:
               Schrijf een programma dat de gebruiker vraagt een getal in te voeren tussen 10 en 100. Vervolgens
               moeten alle oneven getallen vanaf 1 tot en met het opgegeven getal worden weergegeven. Ook
               dient de som van alle getoonde getallen te worden weergegeven.

           */

            Console.WriteLine("Enter a number between 10 and 100 :");
            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nThe all odd numbers from 1 to {userNumber} are given below.\n");
            int sum = 0;
            for (int number = 1; number <= userNumber; number++)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                    Console.WriteLine($" {number}");
                }
            }
            Console.WriteLine($"\nThe sum of all odd numbers from 1 to {userNumber}:\n\n {sum}");

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
