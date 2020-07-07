using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht5
    {
        public Opdracht5()
        {
            /*
             * Opdracht 3.5:
               Schrijf een programma dat de som bepaalt van de getallen 100 tot en met 1000. Je moet gebruik
               maken van een FOR-lus.
            */

            int sum = 0;
            for (int startFrom = 100; startFrom <= 1000; startFrom++)
            {
                sum += startFrom;
            }
            Console.WriteLine($"The sum of the numbers from 100 to 1000: { sum}");


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
