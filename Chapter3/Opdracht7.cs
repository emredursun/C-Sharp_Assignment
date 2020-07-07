using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht7
    {
        public Opdracht7()
        {
            /*
             * Opdracht 3.7:
               Schrijf een programma dat net zo lang gooit met een dobbelsteen tot het totaal van alle worpen
               boven 1000 is gekomen. Laat vervolgens zien hoe vaak gegooid is.
           */


            Random dice = new Random();
            int counter = 0;
            int sum = 0;
            do
            {
                int randomNumber = dice.Next(1, 7);
                sum += randomNumber;
                counter++;

                // Add 1 to the counter everytime it goes through the loop

            }
            while (sum < 1000);
            Console.WriteLine($"The dice are rolled {counter} times to get a total of 1000.");


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
