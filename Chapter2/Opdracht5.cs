using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Opdracht5
    {
        public Opdracht5()
        {
            // Opdracht 2.5:

            Console.WriteLine("Enter your full name: ");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter the base price of your car: ");
            double basePrice = Convert.ToDouble(Console.ReadLine());

            double metallicLack = Math.Round((basePrice * 0.05), 2);
            double lederBekleding = Math.Round((basePrice * 0.05), 2);
            int automatic = 1000;
            double totaleKosten = Math.Round((basePrice + metallicLack + lederBekleding + automatic), 2);

            Console.WriteLine($"Customer name: {customerName}");
            Console.WriteLine($"The base price of the car {basePrice} euro");
            Console.WriteLine($"The metallic paint price {metallicLack} euro");
            Console.WriteLine($"The leather furnishing price {lederBekleding} euro");
            Console.WriteLine($"The automatic transmission price {automatic} euro");
            Console.WriteLine($"Total price {totaleKosten} euro");

            Console.WriteLine("\n Press a button to close the Console Window!");
            Console.ReadKey();
        }
    }
}