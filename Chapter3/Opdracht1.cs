using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht1
    {
        public Opdracht1()
        {
            /*
             * Opdracht 3.1:
               Schrijf een programma dat de getallen 1 tot 25 op het scherm laat zien. Je moet hierbij gebruik
                maken van een FOR-lus.

           */

            Console.WriteLine("Opdracht 3.1: Schrijf een programma dat de getallen 1 tot 25 op het scherm laat zien. Je moet hierbij gebruik maken van een FOR - lus.\n");

            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
