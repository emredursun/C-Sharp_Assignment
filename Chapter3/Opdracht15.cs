using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht15
    {
        /// <summary>
        /// Strips all non digits and non characters from the text.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>The stripped text</returns>
        private string StripText(string input)
        {
            var strippedText = "";
            foreach (var c in input)
            {
                if (char.IsLetterOrDigit(c))
                {
                    strippedText = strippedText + c.ToString().ToLower();
                }
            }
            return strippedText;
        }


        /// <summary>
        /// Reverses the text
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>The reversed text</returns>
        private string ReverseText(string input)
        {
            var textReversed = "";
            for (var i = 0; i < input.Length; i++)
            {

                string letter = input[i].ToString();
                textReversed = letter + textReversed;
            }

            //for(var i = text.Length - 1; i >= 0; i--)
            //{
            //    textReversed = textReversed + text[i];
            //}
            return textReversed;
        }


        public Opdracht15()
        {
            /*
             *  Opdracht 3.15:
                Maak een applicatie die controleert of de tekst die een gebruiker invoert een palindroom is. Weet je
                niet wat een palindroom is zoek dit dan eerst op. De tekst mag nooit langer zijn dan 25 karakters en
                eventuele spaties moeten verwijderd worden.
            */

            // Get input from the user
            var text = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Enter your text to check for palindrome (max. 25 :");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("".PadRight(50, '*'));
                Console.WriteLine("*" + "".PadRight(48, ' ') + "*");
                Console.WriteLine("".PadRight(50, '*'));
                Console.ResetColor();
                Console.CursorLeft = 2;
                Console.CursorTop = Console.CursorTop - 2;
                text = Console.ReadLine();
            } while (text.Length < 1 || text.Length > 25);

            // Remove all characters that are not digit or letter

            //TODO: Enter code to check for palindrome and show result
            var strippedText = StripText(text);


            var textReversed = ReverseText(strippedText);

            //for(var i = text.Length - 1; i >= 0; i--)
            //{
            //    textReversed = textReversed + text[i];
            //}

            Console.CursorTop = Console.CursorTop + 2;
            if (strippedText.ToLower() == textReversed.ToLower())
            {
                Console.WriteLine("Dit is een palindrome");
            }
            else
            {
                Console.WriteLine("Dit is GEEN palindrome");

            }

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
