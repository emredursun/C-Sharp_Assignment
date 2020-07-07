using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Opdracht7
    {
        public Opdracht7()
        {
            /*
             * Opdracht 6.7:
                Schrijf een methode Fibonacci die de fibonacci reeks teruggeeft als een string. De methode
                accepteert één geheel getal als parameter en daarmee wordt bepaald uit hoeveel getallen de reeks
                moet bestaan. Het begin van de fibonacci reeks ziet er als volgt uit: 0 1 1 2 3 5 8 13 etc. De getallen
                worden gescheiden door een spatie.

           */

            Console.Write("\n\tHow many elements of fibonacci sequence you want to print out: ");
            int numberOfElements = int.Parse(Console.ReadLine());

            FibSequence(numberOfElements);

            Console.WriteLine("\n\nPress a button to test another assignment!");
            Console.ReadKey();
        }

        public void FibSequence(int numberOfElements)
        {
            int firstNumber = 0, SecondNumber = 1, nextNumber;
            if (numberOfElements < 2)
            {
                Console.Write("Please Enter a number greater than two");
            }
            else
            {
                //First print first and second number
                Console.WriteLine("");
                Console.Write(firstNumber + " " + SecondNumber + " ");
                //Starts the loop from 2 because 0 and 1 are already printed
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
            }
        }
    }
}
