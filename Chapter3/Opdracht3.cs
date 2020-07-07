using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht3
    {
        public Opdracht3()
        {
            /*
             * Opdracht 3.3:
               Schrijf een programma dat de gebruiker om 2 getallen vraagt. Vervolgens moet je alle
               tussenliggende getallen op het scherm laten zien. Als de gebruiker bijvoorbeeld 5 als eerste en 80 als
               tweede getal invult moeten de getallen 6 tot en met 79 worden weergegeven. Ook als de gebruiker
               80 als eerste en 5 als tweede getal invult moet dezelfde lijst met getallen worden weergegeven. Je
               moet gebruik maken van een FOR-lus.

           */

            Console.WriteLine("Enter your first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your first number: {firstNumber}");
            Console.WriteLine($"Your second number: {secondNumber}");
            Console.WriteLine($"Result: ");

            if (firstNumber < secondNumber)
            {
                for (int num = firstNumber + 1; num < secondNumber; num++)
                {
                    Console.WriteLine(num);
                }
            }
            else if (firstNumber > secondNumber)
            {
                for (int num = firstNumber - 1; num > secondNumber; num--)
                {
                    Console.WriteLine(num);
                }
            }
            else
            {
                Console.WriteLine($"Your entered the same number twice which is {firstNumber}");
            }

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
