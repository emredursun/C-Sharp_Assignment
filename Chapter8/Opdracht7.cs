using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace Chapter7
{
    class Opdracht7
    {
        public Opdracht7()
        {

            /*
             * Opdracht 7.7:
               A new type of fruit machine is being launched to promote Dutch apples and pears. Create a new class of Fruit machine. A slot machine contains apples and pears. The maximum number of each is limited to 50 pieces. Provide two constructors. The first constructor creates an empty slot machine. The other constructor creates a slot machine that you can (partially) fill.

                • supplement apples;
                • supplement pears;
                • to buy apples;
                • to buy pears;
                • see how many pieces of fruit are left in the machine;
                • to check whether a certain type of fruit is sold out.
                
                Then add some methods to:
                Keep in mind that you cannot buy an apple, for example, if there are no more apples in the machine.
           */

            // Creat a new object and add some fruits to the Fruit Machine
            var supplement1 = new FruitMachine(25, 15);

            // Greet user
            Console.WriteLine("Hello, this machine now contains " + supplement1.Appels + " apples and " + supplement1.Pears + " pears.");

            //Ask the user whether to fill or eat fruit and capture wrong characters
            string eatOrFill;
            do
            {
                Console.Write("\nWould you like to eat (E) some fruit, or fill (F) the machine with even more fruit? ");
                eatOrFill = Console.ReadLine().ToUpper();
            }
            while (!eatOrFill.Equals("E") && !eatOrFill.Equals("F"));


            //The user choose to fill
            if (eatOrFill.Equals("F"))
            {
                //Asks user to fill apples or pears
                string prefFill;

                //capture wrong characters
                do
                {
                    Console.Write("\nWould you like to fill the machine with apples (A) or pears (P)? ");
                    prefFill = Console.ReadLine().ToUpper();
                }
                while (!prefFill.Equals("A") && !prefFill.Equals("P"));

                //User choose apples
                if (prefFill.Equals("A"))
                {

                    Console.Write("\nHow many apples would you like to put in the machine: ");
                    int prefAmount;
                    while (!(int.TryParse(Console.ReadLine(), out prefAmount)))
                    {
                        Console.WriteLine("This is the wrong input. Please fill in a number: ");
                    }
                    //try and catch wrong numbers or numbers that exceed maximum amount
                    try
                    {
                        supplement1.FillApples(prefAmount);

                    }
                    catch (ArgumentException argEx)
                    {
                        Console.WriteLine("\nOOPS! Something went wrong!\n");
                        Console.WriteLine(argEx.Message);
                    }
                    finally
                    {
                        Console.WriteLine(
                            "\n\nThanx for your enthusiasm for fruit. " +
                            "\nThe machine now contains " + supplement1.Appels + " apples and " + supplement1.Pears + " pears.");
                    }
                }
                //User choose pears
                if (prefFill.Equals("P"))
                {
                    // User choose pears
                    Console.Write("\nHow many pears would you like to put in the machine: ");
                    int prefAmount;
                    while (!(int.TryParse(Console.ReadLine(), out prefAmount)))
                    {
                        Console.WriteLine("This is the wrong input. Please fill in a number: ");
                    }
                    //try and catch wrong numbers or numbers that exceed maximum amount
                    try
                    {
                        supplement1.FillPears(prefAmount);

                    }
                    catch (ArgumentException argEx)
                    {
                        Console.WriteLine("\nOOPS! Something went wrong!\n");
                        Console.WriteLine(argEx.Message);
                    }
                    finally
                    {
                        Console.WriteLine(
                            "\n\nThanx for your enthusiasm for fruit. " +
                            "\nThe machine now contains " + supplement1.Appels + " apples and " + supplement1.Pears + " pears.");
                    }
                }
            }


            if (eatOrFill.Equals("E"))
            {

                Console.Write("\nWould you like to eat apples (A) or pears (P)? ");
                string prefEat = Console.ReadLine().ToUpper();

                //User choose apples
                if (prefEat.Equals("A"))
                {

                    Console.Write("\nHow many apples would you like to withdraw from the machine: ");
                    int prefAmount;
                    while (!(int.TryParse(Console.ReadLine(), out prefAmount)))
                    {
                        Console.WriteLine("This is the wrong input. Please fill in a number: ");
                    }
                    //try and catch wrong numbers or numbers that exceed maximum amount
                    try
                    {
                        supplement1.WithdrawApples(prefAmount);

                    }
                    catch (ArgumentException argEx)
                    {
                        Console.WriteLine("\nOOPS! Something went wrong!");
                        Console.WriteLine(argEx.Message);
                    }
                    finally
                    {
                        Console.WriteLine(
                            "\n\nThanx for your enthusiasm for fruit. " +
                            "\nThe machine now contains " + supplement1.Appels + " apples and " + supplement1.Pears + " pears.");
                    }
                }
                //User choose pears
                if (prefEat.Equals("P"))
                {

                    Console.Write("\nHow many pears would you like to withdraw from the machine: ");
                    int prefAmount;
                    while (!(int.TryParse(Console.ReadLine(), out prefAmount)))
                    {
                        Console.WriteLine("This is the wrong input. Please fill in a number: ");
                    }
                    //try and catch wrong numbers or numbers that exceed maximum amount
                    try
                    {
                        supplement1.WithdrawPears(prefAmount);

                    }
                    catch (ArgumentException argEx)
                    {
                        Console.WriteLine("\nOOPS! Something went wrong!");
                        Console.WriteLine(argEx.Message);
                    }
                    finally
                    {
                        Console.WriteLine(
                            "\n\nThanx for your enthusiasm for fruit. " +
                            "\nThe machine now contains " + supplement1.Appels + " apples and " + supplement1.Pears + " pears.");
                    }
                }
            }




            Console.WriteLine("Druk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }

    public class FruitMachine
    {
        #region Fields
        private int _apples = 0;
        private int _pears = 0;
        #endregion

        #region Properties
        public int Appels { get => _apples; set => _apples = value; }
        public int Pears { get => _pears; set => _pears = value; }
        #endregion

        #region Constructors
        public FruitMachine() { }

        public FruitMachine(int apples, int pears)
        {
            _apples = apples;
            _pears = pears;
        }
        #endregion


        #region Methods
        // Method to fill the machine with apples and capture wrong input
        public int FillApples(int apples)
        {

            if (apples <= 0)
            {
                throw new ArgumentException(
                    "\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                    "\nYou are not filling the machine, but retreiving apples from the machine." +
                   $"\nThe machine can now hold a maximum of {(50 - _apples)} pieces of apples." +
                    "\nTry to fill a realistic amount. It should be greater than zero!" +
                    "\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            else if ((_apples + apples) > 50)
            {
                throw new ArgumentException(
                    "\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                    "\nYou are trying to Squeeze too many apples in the machine." +
                    "\nThere are now " + _apples + " apples in the machine!" +
                   $"\nAnd the machine can now hold a maximum of {(50 - _apples)} pieces of apples." +
                    "\nPlease try to fill with a smaller amount of apples." +
                    "\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            else
            {
                return _apples += apples;
            }
        }
        //Method to withdraw apples from the machine and capture wrong input
        public int WithdrawApples(int apples)
        {
            if (_apples < 0)
            {
                throw new ArgumentException(
                    "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                    "\nOkay, You know you cannot retrieve a negative amount from the machine, don't you?" +
                    "\nPlease try to retrieve a different amount of apples from the machine." +
                    "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            else if ((_apples - apples) < 0)
            {
                throw new ArgumentException(
                    "\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                    "\nThere are not enough apples left in the machine. Try a smaller amount or, " +
                    "\nIf you like more than the " + _apples + " that are left in the machine," +
                    "\nThen please ask the owner for a apple refill." +
                    "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            else
            {
                return _apples -= apples;
            }
        }

        // Method to fill the machine with pears and capture wrong input
        public int FillPears(int pears)
        {
            if (pears <= 0)
            {
                throw new ArgumentException(
                    "\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                    "\nYou are not filling the machine, but retreiving pears from the machine." +
                   $"\nThe machine can now hold a maximum of {(50 - _pears)} pieces of pears." +
                    "\nTry to fill a realistic amount. It should be greater than zero!" +
                    "\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            else if ((_pears + pears) > 50)
            {
                throw new ArgumentException(
                    "\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                    "\nYou are trying to Squeeze too many pears in the machine." +
                    "\nThere are now " + _pears + " pears in the machine!" +
                   $"\nAnd the machine can now hold a maximum of {(50 - _pears)} pieces of pears." +
                    "\nPlease try to fill with a smaller amount of pears." +
                    "\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            else
            {
                return _pears += pears;
            }
        }

        // Method to withdraw pears from the machine and capture wrong input
        public int WithdrawPears(int pears)
        {
            if (_pears < 0)
            {
                throw new ArgumentException(
                    "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                    "\nOkay, You know you cannot retrieve a negative amount from the machine, don't you?" +
                    "\nPlease try to retrieve a different amount of pears from the machine." +
                    "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            else if ((_pears - pears) < 0)
            {
                throw new ArgumentException(
                    "\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                    "\nThere are not enough pears left in the machine. Try a smaller amount or, " +
                    "\nIf you like more than the " + _pears + " that are left in the machine," +
                    "\nThen please ask the owner for a pear refill." +
                    "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            else
            {
                return _pears -= pears;
            }
        }

        // Methods to retrieve the right number of apples and pears
        public int AppleBalance()
        {
            return _apples;
        }
        public int PearsBalance()
        {
            return _pears;
        }
        #endregion
    }
}
