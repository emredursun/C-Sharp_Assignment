using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht12
    {
        public Opdracht12()
        {
            /*
             *  Opdracht 3.12:
                Laat de gebruiker 10 getallen invoeren en laat daarna zien wat het hoogste en laagste getal was. Doe
                dat door alle ingevoerde getallen weer te geven en maak de tekstkleur van het hoogste getal blauw
                en van het laagste getal rood. De overige getallen moet in de standaardkleur worden weergegeven.
            */

            //maak een array om de in te voeren getallen in op te slaan
            int[] numbers = new int[10];

            //vraag de gebruiker om 10 getallen in te voeren en sla deze op in de array
            Console.WriteLine("Voer 10 getallen tussen de 1 en de 100 in: ");
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //bepaal van elk opvolgend getal in de array of dit groter is of kleiner is dan het vorige. Sla de grootste en de kleinste op in nwe vars
            int largest = numbers[0];
            int smallest = numbers[0];
            for (int big = 1; big < numbers.Length; big++)
            {
                if (largest < numbers[big])
                {
                    largest = numbers[big];
                }
                if (smallest > numbers[big])
                {
                    smallest = numbers[big];
                }
            }


            //laat alle resultaten zien, waarbij het grootste getal blauw wordt weergegeven en het kleinste rood
            Console.WriteLine();
            Console.WriteLine("U heeft de volgende nummers ingevoerd : ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == largest)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (numbers[i] == smallest)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write(numbers[i] + "\t");
                Console.ResetColor();
            }



            //nog even extra de grootste en kleinste weergegeven (omdat het kan, wordt nergens gevraagd)
            Console.WriteLine();
            Console.WriteLine("Het grootste getal is " + largest + ", het kleinste is " + smallest + ".");


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
