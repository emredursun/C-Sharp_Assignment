using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Opdracht6
    {
        public Opdracht6()
        {
            /*
             * Opdracht 6.6:
                Schrijf een methode Machtsverheffen die twee gehele getallen als parameter accepteert. 
                Als resultaat wordt het eerste getal tot de macht het tweede getal teruggegeven. 
                Je mag hierbij geen gebruik maken van de class Math. Je moet zelf met een lus maken om het te bereken.
           */

            Console.Write("\n\tEnter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\tEnter power of the number: ");
            int power = Convert.ToInt32(Console.ReadLine());

            PowerliftingMethods nthPowerMethod = new PowerliftingMethods();
            double nthPower = nthPowerMethod.CalculateNthPower(number, power);
            Console.WriteLine($"\n\t{power} to the power of {number} = {nthPower}");

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }

        class PowerliftingMethods
        {
            public double CalculateNthPower(double number, int power)
            {
                double result = 1;
                for (int i = 1; i <= power; i++)
                {
                    result = result * number;
                }
                return result;
            }
        }
    }
}
