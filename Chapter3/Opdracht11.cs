using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht11
    {
        public Opdracht11()
        {
            /*
             *  Opdracht 3.11:
                Schrijf een applicatie waarbij de gebruiker een geldbedrag invoert en een rentepercentage. Laat
                vervolgens voor de eerstvolgende 10 jaren zien tot welk bedrag het startkapitaal is gegroeid. Ga er
                daarbij vanuit dat het bedrag op 1 januari van het huidige jaar wordt gestort en dat er tussentijds
                geen op- en afnames zijn en dat de rente niet wijzigt.

            */
            Console.WriteLine("This app shows how much your initial capital has grown over the years to come, depending on the amount of money you entered and the interest rate!\n");

            double amountOfMoney;
            double rateOfInterest;
            int years;
            double balance;

            Console.WriteLine("Enter the amount of money :");
            amountOfMoney = Convert.ToDouble(Console.ReadLine());
            balance = amountOfMoney;
            Console.WriteLine("Enter the interest rate: ");
            rateOfInterest = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number of years: ");
            years = int.Parse(Console.ReadLine());

            for (int i = 0; i < years; i++)
            {
                balance = balance * (1 + (rateOfInterest / 100));
            }

            {
                Console.WriteLine($"Your {amountOfMoney}$ starting capital has reached {balance}$ in {years} years with {rateOfInterest}% interest rate.");
            }


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
