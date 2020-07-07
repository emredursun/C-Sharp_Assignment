using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Opdracht2
    {
        public Opdracht2()
        {
            // Opdracht 2.2:

            Console.WriteLine("What is your weight in kg: ");
            string userWeight = Console.ReadLine();
            double doubleWeight = Convert.ToDouble(userWeight);

            Console.WriteLine("What is your length in cm: ");
            string userLength = Console.ReadLine();
            double length = Convert.ToDouble(userLength);

            double lengthMultiply = (length * length);
            double bmi = Math.Round((doubleWeight / lengthMultiply) * 10000, 2);

            Console.WriteLine($"Your BMI is {bmi}");

            Console.WriteLine("\n Press a button to close the Console Window!");
            Console.ReadKey();
        }
    }
}