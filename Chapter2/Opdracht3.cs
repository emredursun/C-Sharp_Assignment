using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Opdracht3
    {
        public Opdracht3()
        {
            // Opdracht 2.3:

            Console.WriteLine("Enter your first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int addNumbers = firstNumber + secondNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} = {addNumbers}");

            int subtractNumbers1 = firstNumber - secondNumber;
            Console.WriteLine($"{firstNumber} - {secondNumber} = {subtractNumbers1}");

            int subtractNumbers2 = secondNumber - firstNumber;
            Console.WriteLine($"{secondNumber} - {firstNumber} = {subtractNumbers2}");

            int multiplyNumbers = firstNumber * secondNumber;
            Console.WriteLine($"{firstNumber} * {secondNumber} = {multiplyNumbers}");

            int divideNumbers1 = firstNumber / secondNumber;
            Console.WriteLine($"{firstNumber} / {secondNumber} = {divideNumbers1}");

            int divideNumbers2 = secondNumber / firstNumber;
            Console.WriteLine($"{secondNumber} / {firstNumber} = {divideNumbers2}");

            int moduloNumbers1 = firstNumber % secondNumber;
            Console.WriteLine($"{firstNumber} % {secondNumber} = {moduloNumbers1}");

            int moduloNumbers2 = secondNumber % firstNumber;
            Console.WriteLine($"{secondNumber} % {firstNumber} = {moduloNumbers2}");

            Console.WriteLine("\n Press a button to close the Console Window!");
            Console.ReadKey();
        }
    }
}