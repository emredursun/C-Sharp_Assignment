using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht21
    {
        public Opdracht21()
        {
            /*
             *  Opdracht 3.21:
                If we want to find the sum of all numbers below 10 that are a multiple of 3 or 5, we get 3 + 5 + 6 + 9 = 23. 
                Write a program that calculates the sum of all multiples of 3 or 5 below 1000.
            */

            Console.WriteLine("Enter a number to find the sum of the multiples of 3 and 5 below the number you entered: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < userNumber; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine($"The sum of all multiples of 3 or 5 below {userNumber} is equal to {sum}");


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
