using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht18
    {
        public Opdracht18()
        {
            /*
             *  Opdracht 3.18:
                Maak een applicatie die controleert of de invoer een geldig email adres is.
                Er moet gevalideerd worden op aanwezigheid van een @ en een top level domainname zoals .com of .nl
            */

            Console.WriteLine("Geef je e-mailadres in: ");
            string emailaddress = Console.ReadLine();

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(emailaddress);
            Console.WriteLine($"{match}");

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
