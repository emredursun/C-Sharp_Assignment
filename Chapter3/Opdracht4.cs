using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht4
    {
        public Opdracht4()
        {
            /*
             * Opdracht 3.4:
               Schrijf een programma dat van alle jaren vanaf 1900 laat zien of het wel of geen schrikkeljaar is. Je
                dient zelf uit te zoeken hoe je kunt bepalen of een jaar wel of geen schrikkeljaar is. Je moet gebruik
                maken van een FOR-lus.
            */

            for (int startFrom = 1900; startFrom < 2000; startFrom++)
            {

                if (startFrom % 400 == 0 || startFrom % 100 == 0 || startFrom % 4 == 0)
                {
                    Console.WriteLine($"{startFrom} is a leap year!");
                }
                else
                {
                    Console.WriteLine($"{startFrom} is not a leap year!");
                }
            }


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
