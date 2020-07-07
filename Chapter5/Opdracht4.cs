using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Opdracht4
    {
        public Opdracht4()
        {
            /*
             * Opdracht 5.4:
               Maak een programma dat een geldbedrag in euro’s omrekent naar 5 door jou te kiezen valuta. Het
               bedrag in euro’s moet door de gebruiker worden ingevoerd. Gebruik de koersen die gelden op de
               dag dat de opdracht wordt gemaakt.

           */

            Console.WriteLine("\nThis script converts an amount of money in euros into 5 other currencies!\n\n");

            Console.WriteLine("Enter the amount of money(euro) you want to exchange: \n");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("".PadRight(20, '*'));
            Console.WriteLine("*Amount:" + "".PadRight(7, ' ') + "EURO*");
            Console.WriteLine("".PadRight(20, '*'));
            Console.ResetColor();
            Console.CursorLeft = 8;
            Console.CursorTop = Console.CursorTop - 2;

            var inputAmount = Console.ReadLine();
            double euroAmount = Convert.ToDouble(inputAmount.Replace(".", ","));

            Console.WriteLine("\n\nThe exchange rates:");
            Console.WriteLine("1 Euro = 7.47 Turkish lira");
            Console.WriteLine("1 Euro = 1.09 Dollar");
            Console.WriteLine("1 Euro = 80.43 Ruble");
            Console.WriteLine("1 Euro = 4.83 Leu");
            Console.WriteLine("1 Euro = 118.41 Yen");
            Console.WriteLine("\n");
            Console.WriteLine($"{euroAmount} Euro: ");
            Console.WriteLine($"\t {Math.Round((7.47 * euroAmount), 2)} Turkish lira");
            Console.WriteLine($"\t {Math.Round((1.11 * euroAmount), 2)} American Dollar");
            Console.WriteLine($"\t {Math.Round((80.43 * euroAmount), 2)} Russian Ruble");
            Console.WriteLine($"\t {Math.Round((4.83 * euroAmount), 2)} Romanian Leu");
            Console.WriteLine($"\t {Math.Round((118.41 * euroAmount), 2)} Japanse Yen");


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
