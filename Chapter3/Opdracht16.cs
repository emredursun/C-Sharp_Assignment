using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht16
    {
        public Opdracht16()
        {
            /*
             *  Opdracht 3.16:
                Zet elke 2e karakter in een stukje tekst om in een hoofdletter.
                Laat de gebruiker een tekst invoeren en toon de ingevoerde tekst aan de gebruiker zo dat elke 2e
                karakter een hoofdletter is. Bijvoorbeeld: Hello world -> hElLo WoRlD.
            */

            Console.WriteLine("Geef uw tekst in...");
            string tekst = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            bool uppercase = false;

            foreach (char c in tekst)
            {
                if (uppercase)
                    sb.Append(char.ToUpper(c));
                else
                    sb.Append(char.ToLower(c));

                uppercase = !uppercase;
            }

            string newString = sb.ToString();
            Console.WriteLine(newString);

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
