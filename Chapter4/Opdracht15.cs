using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Opdracht15
    {
        public Opdracht15()
        {
            Console.Clear();
            Console.Write("Wat is het cijfer voor wiskunde (10 - 100)? ");
            int wiskunde = int.Parse(Console.ReadLine());
            Console.Write("Wat is het cijfer voor scheikunde (10 - 100)? ");
            int scheikunde = int.Parse(Console.ReadLine());
            Console.Write("Wat is het cijfer voor natuurkunde (10 - 100)? ");
            int natuurkunde = int.Parse(Console.ReadLine());
            var oldColor = Console.ForegroundColor;
            if(wiskunde < 40 || natuurkunde < 40 || scheikunde < 40 || wiskunde == 0 || natuurkunde == 0 || scheikunde == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("De kandidaat is niet toelaatbaar.");
            }
            else if(wiskunde + natuurkunde + scheikunde >= 180)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("De kandidaat is toelaatbaar.");
            }
            else if(wiskunde >= 60 && (scheikunde >= 60 || natuurkunde >= 60))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("De kandidaat is toelaatbaar.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("De kandidaat is niet toelaatbaar.");
            }
            Console.WriteLine("Druk op een toets om af te sluiten ...");
            Console.ReadKey();
            Console.ForegroundColor = oldColor;
        }
    }
}
