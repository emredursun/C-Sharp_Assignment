using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Opdracht8
    {
        public Opdracht8()
        {
            ConsoleKeyInfo choice = new ConsoleKeyInfo();
            while (choice.KeyChar != '9')
            {
                Console.Clear();
                Console.WriteLine("Welke taal wil je?");
                Console.WriteLine();
                Console.WriteLine("1. Nederlands");
                Console.WriteLine("2. Duits");
                Console.WriteLine("3. Engels");
                Console.WriteLine("4. Frans");
                Console.WriteLine("5. Spaans");
                Console.WriteLine("6. Zweeds");
                Console.WriteLine("9. Exit");
                Console.WriteLine();
                Console.Write("Jouw keuze: [ ]");
                Console.CursorLeft = 13;
                choice = Console.ReadKey();
                Console.WriteLine();
                var result = "";
                switch (choice.KeyChar)
                {
                    case '1':
                        result = "De huidige maand is " + DateTime.Today.ToString("MMMM", new CultureInfo("nl-NL"));
                        break;
                    case '2':
                        result = "Der aktuelle Monat ist " + DateTime.Today.ToString("MMMM", new CultureInfo("de-DE"));
                        break;
                    case '3':
                        result = "The current month is " + DateTime.Today.ToString("MMMM", new CultureInfo("en-US"));
                        break;
                    case '4':
                        result = "Le mois en cours est " + DateTime.Today.ToString("MMMM", new CultureInfo("fr-FR"));
                        break;
                    case '5':
                        result = "El mes actual es " + DateTime.Today.ToString("MMMM", new CultureInfo("es-ES"));
                        break;
                    case '6':
                        result = "Den nuvarande månaden är " + DateTime.Today.ToString("MMMM", new CultureInfo("sv-SE"));
                        break;
                    case '9':
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine();
                Console.Write(result);
                for (int i = 0; i < 5; i++)
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(" .");
                }
            }

        }
    }
}
