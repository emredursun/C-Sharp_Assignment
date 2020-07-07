using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht14
    {
        public Opdracht14()
        {
            /*
             *  Opdracht 3.14:
                Maak een decimaal naar binair en hexadecimaal getal converter.
                De gebruiker moet een decimaal getal ingeven waarna de applicatie de binaire en hexadecimale
                waarde toont aan de gebruiker.

            */

            Console.WriteLine("Dit scriptje zet decimale getallen om naar binaire en hexadecimale notatie");
            Console.WriteLine();

            //Getal invoeren 
            Console.WriteLine("Voer een geheel getal tussen de 0 en de 255 in...:");
            int getal = Convert.ToInt32(Console.ReadLine());

            //input omzetten naar hex-notatie
            string hexGetal = getal.ToString("X");

            //input omzetten naar bin-notatie.
            string binGetal = Convert.ToString(getal, 2);

            //output netjes presenteren
            Console.WriteLine();
            Console.WriteLine("U heeft het volgende getal ingevoerd :\t" + getal);
            Console.WriteLine();
            Console.WriteLine($"De hexadecimale notatie van dit getal = " + hexGetal);
            Console.WriteLine("De binaire notatie van dit getal =\t" + binGetal);


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
