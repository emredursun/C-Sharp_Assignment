using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht20
    {
        public Opdracht20()
        {

            /*
             *  Opdracht 3.20:
                Vraag de gebruiker om een getal in te voeren tussen 10 en 1.000.000 en laat vervolgens alle
                disarium nummers zien die kleiner zijn dan het opgegeven getal.
                Een voorbeeld van een disarium nummer is 135.
                We berekenen het eerste cijfer tot de macht 1, het tweede cijfer tot de macht 2, het derde cijfer tot
                de macht 3 etc. Die uitkomsten tellen we bij elkaar op en als deze uitkomst gelijk is aan het getal zelf
                dan spreken we van een disarium nummer. In het voorbeeld:
                1 tot de macht 1 = 1
                3 tot de macht 2 = 9
                5 tot de macht 3 = 125
                1 + 9 + 125 = 135 dus dit is een disarium nummer
            */

            Console.WriteLine("Dit programma laat alle kleinere dan het opgegeven getal disariumgetallen zien.\n");

            //input getal -wat dus de non-inclusive bovengrens wordt
            Console.WriteLine("Voer een getal tussen de 10 en de 1.000.000 in:...");
            int bovenGrens = Convert.ToInt32(Console.ReadLine());

            //Berekening afgekeken van https://dotnetfiddle.net/ljpzdL
            //Lastig : alle converts (Math.Pow bv werkt alleen met doubles).
            Console.WriteLine($"Allemaal desariumgetal nummers tussen 0 en {bovenGrens}: \n");

            for (int i = 1; i <= bovenGrens; i++)
            {
                double desBerekening = 0;

                //om de individuele cijfers van een getal te kunnen gebruiken moet het een string zijn
                string strI = Convert.ToString(i);

                //loop door de stringlengte, doe de desariumbewerking op elk cijfer van het getal (1e tot de 1emacht , 2e tot de 2e macht etc) en tel dat op  
                for (int j = 0; j < strI.Length; j++)
                {
                    desBerekening += Math.Pow(Convert.ToDouble((strI[j]).ToString()), (Convert.ToDouble(j) + 1));

                }

                //als i (uit het bereik tot de ingevoerde bovengrens hetzelfde is als de desariumberekning, print die dan
                if (Convert.ToInt32(desBerekening) == i)
                {
                    Console.WriteLine(i + " is een desariumgetal");
                }

            }

            //Vaste afsluiter
            Console.WriteLine("\n");
            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
