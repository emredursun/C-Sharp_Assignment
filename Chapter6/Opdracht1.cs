using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Opdracht1
    {
        public Opdracht1()
        {
            /*
             * Opdracht 6.1:
                Schrijf een methode LuizenMoeder die de volgende boodschap als resultaat geeft: Hallo allemaal,
                wat leuk dat je er bent. De methode heeft geen parameters.
           */

            LuizenMoeder();

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }

        static void LuizenMoeder()
        {
            string message = "\n\tHallo allemaal, wat leuk dat je er bent.";
            Console.WriteLine(message);
        }
    }
}
