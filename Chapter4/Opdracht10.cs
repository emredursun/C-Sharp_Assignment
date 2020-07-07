using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Opdracht10
    {
        public Opdracht10()
        {
            /*
             * Opdracht 4.10:
               Vraag de gebruiker het nummer van een dag in te vullen en laat vervolgens als uitvoer de naam van
               de dag zien. Maandag is dag nummer 1.
           */

            int userNumber = 0;
            string weekDay = "";
            while (userNumber != 8)
            {
                Console.Write("\nVoer een nummer in van 1 tot 7 (1 - 7, 8 = STOP): ");
                userNumber = int.Parse(Console.ReadLine());
                switch (userNumber)
                {
                    case 1:
                        weekDay = "Maandag";
                        Console.WriteLine($"{weekDay} is dag nummer {userNumber}.");
                        break;
                    case 2:
                        weekDay = "Dinsdag";
                        Console.WriteLine($"{weekDay} is dag nummer {userNumber}.");
                        break;
                    case 3:
                        weekDay = "Woensdag";
                        Console.WriteLine($"{weekDay} is dag nummer {userNumber}.");
                        break;
                    case 4:
                        weekDay = "Donderdag";
                        Console.WriteLine($"{weekDay} is dag nummer {userNumber}.");
                        break;
                    case 5:
                        weekDay = "Vrijdag";
                        Console.WriteLine($"{weekDay} is dag nummer {userNumber}.");
                        break;
                    case 6:
                        weekDay = "Zaterdag";
                        Console.WriteLine($"{weekDay} is dag nummer {userNumber}.");
                        break;
                    case 7:
                        weekDay = "Zondag";
                        Console.WriteLine($"{weekDay} is dag nummer {userNumber}.");
                        break;
                    case 8:
                        Console.WriteLine("Bye bye ...");
                        System.Threading.Thread.Sleep(3000);
                        return;
                    default:
                        Console.WriteLine("Ongeldige keuze ...");
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
            }

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
