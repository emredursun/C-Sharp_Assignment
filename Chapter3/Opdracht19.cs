using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht19
    {
        public Opdracht19()
        {

            /*
             *  Opdracht 3.19:
                Schrijf een programma dat de gebruiker vraagt de temperatuur in te voeren in graden Celsius.
                Vervolgens moet de temperatuur in een staafdiagram worden weergegeven. De
                minimumtemperatuur is -30 graden en de maximumtemperatuur +50 graden.

            */
            Console.WriteLine("Dit programma poogt een gekleurd staafdiagram te printen n.a.v. invoer van een temperatuur\n");
            //Wat ik in de opdracht lees is : print een gekleurd staafje met een grote en kleur die afhangt van de inputwaarde

            //input temp, tussen -30 en +50 Celsius
            Console.WriteLine("Voer de temperatuur in (tussen -30 en +50 graden)");
            int invoerTemp = Convert.ToInt32(Console.ReadLine());

            //Beetje ruimte creeren anders staat alles zo dicht op elkaar
            Console.WriteLine("\n\n");

            //bepaal de te gebruiken kleur
            if (invoerTemp < -20)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            else if (invoerTemp >= -20 && invoerTemp < -10)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            else if (invoerTemp >= -10 && invoerTemp < 0)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
            else if (invoerTemp >= 0 && invoerTemp < 10)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else if (invoerTemp >= 10 && invoerTemp < 20)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            else if (invoerTemp >= 20 && invoerTemp < 30)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (invoerTemp >= 30 && invoerTemp < 50)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            else
            {
                Console.WriteLine("de ingevoerde temperatuur past niet in het bereik van de grafiek");
                //beetje stiekem dit : ik wil grotere of kleinere waarden dan het opgegeven bereik niet laten zien > print black on black ;-)
                Console.BackgroundColor = ConsoleColor.White;
            }

            //print een staafje wat overeenkomt met de tempwaarde
            for (int i = -30; i <= invoerTemp; i++)
            {
                Console.Write(" ");
            }

            //reset tekstkleur zodat de schaalverdeling in de normale kleur wordt weergegeven
            Console.ResetColor();

            //print de schaalverdeling
            Console.WriteLine("\n");
            Console.WriteLine("|=========|=========|=========|=========|=========|=========|=========|=========|");
            Console.WriteLine("-30      -20       -10        0         10        20        30        40        50  graden Celsius");

            //Vaste afsluiter
            Console.WriteLine("\n");
            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
