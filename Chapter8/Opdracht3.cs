using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Opdracht3
    {
        public Opdracht3()
        {

            /*
             * Opdracht 7.3:
               Design a class for storing the data of a fraction, namely numerator and denominator. Provide 2 constructors. The first constructor creates a new fraction with default values. The second constructor provides parameters for entering numerator and denominator. Add methods for querying and adjusting the numerator and denominator. Of course you also provide a method to calculate the quotient.
           */

            Fraction F1 = new Fraction();
            Console.Write("Default Fraction: ");
            Console.WriteLine(F1.CreateFraction());
            Console.WriteLine();

            Fraction F2 = new Fraction(17, 5);
            Console.Write("Fraction: ");
            Console.WriteLine(F2.CreateFraction());
            Console.Write("Quotient: ");
            Console.WriteLine(F2.CalculateQuotient());


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }

    public class Fraction
    {
        // Fields
        #region
        // Instance variables
        private int _numerator = 3;
        private int _denominator = 5;
        #endregion

        // Constructors
        #region
        public Fraction()
        {

        }
        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }
        #endregion

        // Methods
        #region
        public string CreateFraction()
        {
            string result = _numerator + "/" + _denominator;
            return (result);
        }

        public int CalculateQuotient()
        {
            int result = _numerator / _denominator;
            return (result);
        }
        #endregion
    }

}
