using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Opdracht5
    {
        public Opdracht5()
        {
            /*
             * Opdracht 5.5:
               Maak een programma dat berekent hoeveel het stallen van een camper kost. De verhuurder rekent
               een prijs van 1,50 euro per vierkante meter per maand. Als een contract voor minimaal 3 jaar wordt
               aangegaan wordt een korting van 10% van het bedrag verstrekt en als een contract van minimaal 2
               jaar wordt aangegaan bedraagt de korting 5%.
               Als invoer wordt de breedte en de lengte van een camper opgegeven en als uitvoer moet worden
               getoond wat de kosten zijn voor 1 jaar stalling, voor 2 jaar stalling en voor 3 jaar stalling.
           */

            Console.WriteLine("\tThis script calculates how much it costs to park a motor home.\n" +
                "\tA contract for at least 36 months is entered into, the discount will be 10%\n" +
                "\tOr a contract of at least 24 months is entered into, the discount will be 5%.\n" +
                "\tThe landlord charges a price of 1.50 euros per square meter per month.\n");
            

            Console.Write("How many months do you want to rent: ");
            double rentalTime = Convert.ToDouble(Console.ReadLine());
            Console.Write("How many square meters would you like to rent: ");
            double areaAmount = Convert.ToDouble(Console.ReadLine());

            double rentalCost;
            if (rentalTime >= 36)
            {
                rentalCost = Math.Round((rentalTime * areaAmount * 1.5 * 0.90), 2);
                Console.WriteLine($"\nThe rental cost of '{areaAmount}' square meter for '{rentalTime}' months is '{rentalCost}' euro.");
            }
            else if (rentalTime >= 24 && rentalTime <= 36 )
            {
                rentalCost = Math.Round((rentalTime * areaAmount * 1.5 * 0.95), 2);
                Console.WriteLine($"\nThe rental cost of '{areaAmount}' square meter for '{rentalTime}' months is '{rentalCost}' euro.");
            }
            else
            {
                rentalCost = Math.Round((rentalTime * areaAmount * 1.5), 2);
                Console.WriteLine($"\nThe rental cost of '{areaAmount}' square meter for '{rentalTime}' months is '{rentalCost}' euro.");
            }


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
