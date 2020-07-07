using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht9
    {
        public Opdracht9()
        {
            /*
             *  Opdracht 3.9:
                Schrijf een programma dat de gebruiker vraagt een getal in te voeren tussen 10 en 20. Vervolgens
                moeten alle getallen vanaf 1 tot en met het opgegeven getal worden weergegeven, met daarachter
                het resultaat van de berekening waarbij het getal tot dezelfde macht wordt verheven.
                Dus bijvoorbeeld 1 tot de macht 1, 2 tot de macht 2, 3 tot de macht 3, 4 tot de macht 4 etc.
            */

            Console.WriteLine("Enter a number between 10 and 20 :");
            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"The squares of each number from 1 to {userNumber} are given below.");

            for (int number = 1; number <= userNumber; number++)
            {
                Console.WriteLine($"{number * number}");
            }

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
