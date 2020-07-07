using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Opdracht4
    {
        public Opdracht4()
        {
            // Opdracht 2.4:

            Console.WriteLine("Geef het kenteken van uw auto?");
            string kenteken = Console.ReadLine();

            Console.WriteLine("Geef het merk van uw auto?");
            string merk = Console.ReadLine();

            Console.WriteLine("Geef het model van uw auto?");
            string model = Console.ReadLine();

            Console.WriteLine("Geef het bouwjaar van uw auto in?");
            int intBouwjaar = Convert.ToInt32(Console.ReadLine());

            var date = new DateTime(2018, 10, 29);
            int jaar = date.Year;
            int leeftijdBouwjaar = jaar - intBouwjaar;
            Console.WriteLine($"De {merk} {model} met als kenteken {kenteken} is {leeftijdBouwjaar} jaar oud");

            Console.WriteLine("\n Press a button to close the Console Window!");
            Console.ReadKey();
        }
    }
}