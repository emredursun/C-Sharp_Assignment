using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Opdracht1
    {
        public Opdracht1()
        {
            // Opdracht 2.1:

            string name = "Emre";
            string adress = "De Boorenmaat 21";
            string PostCode = "7481 DV";
            string livingPLace = "Haaksbergen";
            int age = 32;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine(name);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(age);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(adress);
            Console.WriteLine(PostCode + livingPLace);

            Console.WriteLine("\nPress a button to close the Console Window!");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
