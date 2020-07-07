using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Opdracht4
    {
        public Opdracht4()
        {
            /*
             * Opdracht 6.4:
                 Schrijf een methode Calculate die als resultaat de uitkomst van een berekening geeft. De methode 
                 moet 3 parameters hebben:
                    • De eerste parameter is voor het eerste getal. Dit getal kan ook decimalen bevatten
                    • De tweede parameter is voor het tweede getal en kan ook decimalen bevatten.
                    • De derde parameter is één enkel teken (char) dat aangeeft welke berekening uitgevoerd dient te worden:

                    ○ + : de som va de getallen
                    ○ - : het verschil tussen beide getallen
                    ○ * : het product van beide getallen
                    ○ / : het quotiënt (eerste getal gedeeld door tweede getal; denk eraan: delen door nul blijft flauwekul)
                    ○ % : het restant van eerste getal gedeeld door tweede getal (delen door nul is???)
            */


            BACKTOTOP:
            double firstNumber, secondNumber;
            Console.Write("\n\tEnter your 'first number': ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\tEnter your 'second number': ");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            MAKEYOURCHOICE:
            Console.Write(" Make your choice? (Addition:'1' || Subtraction:'2' || Multiplication:'3' || Division:'4' || Module:'5') => ");
            char userChoice = Convert.ToChar(Console.ReadLine());
            switch (userChoice)
            {
                case '1':
                    FourOperations DoAddition = new FourOperations();
                    double additionResult = DoAddition.SumNumbers(firstNumber, secondNumber);
                    Console.WriteLine("\n\tAddition Result: {0}", additionResult);
                    break;
                case '2':
                    FourOperations DoSubtraction = new FourOperations();
                    double subtractionResult = DoSubtraction.SubtractNumbers(firstNumber, secondNumber);
                    Console.WriteLine("\n\tSubtraction Result: {0}", subtractionResult);
                    break;
                case '3':
                    FourOperations DoMultiplication = new FourOperations();
                    double multiplicationResult = DoMultiplication.MultiplyNumbers(firstNumber, secondNumber);
                    Console.WriteLine("\n\tMutiplication Result: {0}", multiplicationResult);
                    break;
                case '4':
                    FourOperations DoDivision = new FourOperations();
                    double divisionResult = DoDivision.DevideNumbers(firstNumber, secondNumber);
                    Console.WriteLine("\n\tDivision Result: {0}", divisionResult);
                    break;
                case '5':
                    FourOperations FindModule = new FourOperations();
                    double ModuleResult = FindModule.FindModuleOfNumbers(firstNumber, secondNumber);
                    Console.WriteLine("\n\tDivision Result: {0}", ModuleResult);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("You entered an invalid value! Please enter a valid value.\n");
                    goto MAKEYOURCHOICE;
            }

            TRYAGAIN:
            Console.Write("\nWould you like to do another four operation? (YES:'y' or NO:'n') => ");
            string doAnotherOperation = Console.ReadLine();
            if (doAnotherOperation == "y" || doAnotherOperation == "Y" || doAnotherOperation == "YES" || doAnotherOperation == "yes")
            {
                Console.Clear();
                goto BACKTOTOP;
            }
            else if (doAnotherOperation == "n" || doAnotherOperation == "N" || doAnotherOperation == "NO" || doAnotherOperation == "no")
            {
                Console.WriteLine("Bye bye ...");
                Console.WriteLine("\nPress any key to close the Console Window!");
            }
            else
            {
                Console.WriteLine("You entered an invalid value! Please try again.");
                goto TRYAGAIN;
            }

            Console.ReadKey();
        }

        class FourOperations
        {
            public double SumNumbers(double firstNumer, double secondNumber)
            {
                return (firstNumer + secondNumber);
            }
            public double SubtractNumbers(double firstNumer, double secondNumber)
            {
                return (firstNumer - secondNumber);
            }
            public double MultiplyNumbers(double firstNumer, double secondNumber)
            {
                return (firstNumer * secondNumber);
            }
            public double DevideNumbers(double firstNumer, double secondNumber)
            {
                return (firstNumer / secondNumber);
            }
            public double FindModuleOfNumbers(double firstNumer, double secondNumber)
            {
                return (firstNumer % secondNumber);
            }
        }
    }
}

