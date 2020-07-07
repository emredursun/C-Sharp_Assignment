using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Opdracht3
    {
        public Opdracht3()
        {
            /*
             * Opdracht 5.3:
               Maak een programma dat de inhoud van een kubus berekent. De gebruiker voert hoogte, lengte en
               breedte in en de inhoud wordt weergegeven met 2 decimalen.

           */

            Console.WriteLine("\nThis script calculates the volume of a rectangular prism or the volume of a cube!\n\n");

            Console.Write("Enter the height of the prism: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the length of the prism: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width of the prism: ");
            double width = Convert.ToDouble(Console.ReadLine());


            double volumeOfPrism = height * length * width;

            if (length != width || length != height)
            {
                Console.WriteLine($"\nA rectangular prism with the measurements entered height: {height} length: {length} width: {width}");
                Console.WriteLine($"The volume of the rectangular prism is {Math.Round(volumeOfPrism, 2)}");
            }
            else
            {
                Console.WriteLine($"\nA cube with the measurements entered height: {height} length: {length} width: {width}");
                Console.WriteLine($"The volume of the cube is {Math.Round(volumeOfPrism, 2)}");
            }


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
