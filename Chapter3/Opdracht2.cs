using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht2
    {
        public Opdracht2()
        {
            /*
             * Opdracht 3.2:
               Schrijf een programma dat de getallen 1 tot en met 25 op het scherm laat zien met daarachter het
                kwadraat van dat getal. Je moet gebruik maken van een FOR-lus

           */

            Console.WriteLine("Opdracht 3.2: Schrijf een programma dat de getallen 1 tot en met 25 op het scherm laat zien met daarachter het kwadraat van dat getal.\n");

            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine("The square of " + i + " is " + (i * i));
            }

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
