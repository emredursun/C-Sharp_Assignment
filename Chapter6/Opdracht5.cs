using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Opdracht5
    {
        public Opdracht5()
        {
            /*
             * Opdracht 6.5:
                Schrijf een methode LegeRegels die lege regels schrijft in een console applicatie. De gebruiker geeft
                een aantal als geheel getal en het gewenste aantal lege regels wordt naar de console geschreven.
           */

            Console.WriteLine("\n\tThis script helps users to write empty rows with empty characters in a console application.");

            string mainInput;
            int emptyRows;
            int emptyChars;

            Console.Write("\nEnter the number of empty rows and and characters and seperate them by a dash sign(rows-chars) => ");

            mainInput = Console.ReadLine();
            emptyRows = Convert.ToInt32(mainInput.Split('-')[0]);
            emptyChars = Convert.ToInt32(mainInput.Split('-')[1]);

            LegeRegels(emptyRows, emptyChars);

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }

        static void LegeRegels(int emptyRows, int emptyChars)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            for (var i = 0; i < emptyRows; i++)
            {
                Console.WriteLine("".PadRight(emptyChars, '_'));
            }
            Console.ResetColor();
        }
    }
}
