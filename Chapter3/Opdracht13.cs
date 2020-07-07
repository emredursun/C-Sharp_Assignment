using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht13
    {
        public Opdracht13()
        {
            /*
             *  Opdracht 3.13:
                Laat de gebruiker een stuk tekst invoeren en laat als uitvoer zien hoeveel klinkers, hoeveel
                medeklinkers, hoeveel cijfers en hoeveel andere tekens er in de tekst voorkomen.
            */

            Console.WriteLine("Dit script controleert hoeveel klinkers, medeklinkers, cijfers en andere tekens voorkomen in een stuk ingevoerde tekst");
            Console.WriteLine("----------");

            //get the text to analyse, convert all chars in tekst to lowercase, get stringlength
            Console.WriteLine("Voer een tekstje in : ...");
            string ruweTekst = Console.ReadLine();
            int tekstLengte = ruweTekst.Length;
            string invoerTekst = ruweTekst.ToLower();

            //stel de counters in
            int tekenTeller = 0;
            int klinkerCount = 0;
            int medeKlinkerCount = 0;
            int numberCount = 0;
            int otherCount = 0;

            //check per teken of het voorkomt in de verschillende verzamelingen, zoja verhoog de betreffende couunter met 1
            while (tekenTeller < tekstLengte)
            {
                if (invoerTekst[tekenTeller] == 'a' || invoerTekst[tekenTeller] == 'e' || invoerTekst[tekenTeller] == 'i' || invoerTekst[tekenTeller] == 'o' || invoerTekst[tekenTeller] == 'u')
                {
                    klinkerCount++;
                }
                else if (invoerTekst[tekenTeller] >= 'a' && invoerTekst[tekenTeller] <= 'z')
                {
                    medeKlinkerCount++;
                }

                else if (invoerTekst[tekenTeller] >= '0' && invoerTekst[tekenTeller] <= '9')
                {
                    numberCount++;
                }
                else
                {
                    otherCount++;
                }

                tekenTeller++;

            }

            //output netjes presenteren
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("De ingevoerde tekst is " + tekstLengte + " tekens lang, en bevat :");
            Console.WriteLine("----------");
            Console.WriteLine("\t" + klinkerCount + " klinkers");
            Console.WriteLine("\t" + medeKlinkerCount + " medeklinkers");
            Console.WriteLine("\t" + numberCount + " cijfers");
            Console.WriteLine("\t" + otherCount + " andere tekens");


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
