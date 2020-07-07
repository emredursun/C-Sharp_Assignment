using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Opdracht2
    {
        public Opdracht2()
        {
            /*
             * Opdracht 5.2:
               Maak een programma dat het leeftijdsverschil in dagen berekent tussen twee echtgenoten. Het
               programma vraagt eerst om de geboortedatum van de vrouw en daarna om de geboortedatum van
               de man. Gebruik de functie voor de absolute waarde om ervoor te zorgen dat altijd een positief getal
               wordt weergegeven.

           */

            Console.WriteLine("\nThis script calculate the age difference in days between 2 entered birth dates!\n\n");

            Console.WriteLine("Enter the birth date of the woman as shown here (dd-mm-jjjj): ");
            DateTime womanBirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the birth date of the man as shown here (dd-mm-jjjj): ");
            DateTime manBirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Woman's birthday: {womanBirthDate.Date: dd MMMM yyyy}.");
            Console.WriteLine($"Man's birthday: {manBirthDate.Date: dd MMMM yyyy}.");
            Console.WriteLine();


            if (womanBirthDate > manBirthDate)
            {
                // Calculate the interval between the two dates.  
                TimeSpan dateSpan = womanBirthDate - manBirthDate;
                Console.WriteLine("The difference between the two entered dates is " + dateSpan.Days + " days.");
            }
            else
            {
                // Calculate the interval between the two dates.  
                TimeSpan dateSpan = manBirthDate - womanBirthDate;
                Console.WriteLine("The difference between the two entered dates is " + dateSpan.Days + " days.");
            }

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
