using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Opdracht22
    {
        public Opdracht22()
        {

            /*
             *  Opdracht 3.22:
                Bij opdracht 3.8 heb je al kennis gemaakt met de fibonacci reeks. Schrijf nu een programma dat de
                som berekent van alle even getallen in de fibonacci reeks die kleiner zijn dan 4 miljoen.
            */

            int firstNumber = 0, secondNumber = 1, nextNumber, numberOfElements;

            Console.Write("The sum of the double numbers among the first 34 elements of the Fibonacci series is less than 4 million. So write here 34! ");
            numberOfElements = int.Parse(Console.ReadLine());

            if (numberOfElements < 2)
            {
                Console.Write("Please Enter a number greater than two");
            }
            else
            {
                //First print first and second number
                Console.WriteLine(firstNumber);
                Console.WriteLine(secondNumber);
                //Starts the loop from 2 because 0 and 1 are already printed
                int total = 0;
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + secondNumber;
                    Console.WriteLine(nextNumber);
                    if (nextNumber % 2 == 0)
                    {
                        total += nextNumber;
                    }
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }
                Console.WriteLine($"\nThe sum of all even fibonacci numbers less than 4.000.000 is equal to {total}");
            }

            //Vaste afsluiter
            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
