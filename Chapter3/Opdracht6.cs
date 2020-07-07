using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht6
    {
        public Opdracht6()
        {
            /*
             *  Opdracht 3.6:
                Schrijf een programma dat het gooien met 5 dobbelstenen simuleert. Laat als uitvoer de worpen
                zien en het totaal en het gemiddelde van alle stenen. Voor deze opdracht moet je gebruik maken
                van een FOR-lus. Je moet zelf uitzoeken hoe je met C# random getallen kunt genereren.
            */

            Random dice = new Random();
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                int randomNumber = dice.Next(1, 7);
                sum += randomNumber;
                Console.WriteLine(i + " random number: " + randomNumber);
            }

            decimal awarage = sum / 5;

            Console.WriteLine($"The sum of the random numbers: {sum}");
            Console.WriteLine($"The approximate average of the random numbers: {awarage}");


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
