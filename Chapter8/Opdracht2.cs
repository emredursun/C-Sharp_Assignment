using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Opdracht2
    {
        public Opdracht2()
        {

            /*
             * Opdracht 7.2:
                Ontwerp een klasse voor de opslag van de gegevens van een rechthoek. Sla de
                basis en de hoogte elk op in een objectvariabele. Geef de klasse een constructor
                waaraan je de basis en de hoogte kan meegeven als parameter. Maak een methode
                die de oppervlakte van de rechthoek als waarde teruggeeft. Voorzie ook methoden
                waarmee je de waarden van de basis en de hoogte kan opvragen en aanpassen.
           */

           // Rectangle 1 => R1
            double lengthR1 = 3;
            double widthR1 = 5;
            Rectangle R1 = new Rectangle(lengthR1, widthR1);

            double areaR1 = R1.CalculateArea();
            double circumferenceR1 = R1.CalculateCircumference();
            Console.WriteLine("\n\t*** Rectangle 1 ***");
            Console.WriteLine("\nLength: {0} \nWidth: {1}", lengthR1, widthR1);
            Console.WriteLine("\n\tArea: {0} \n\tCircumference: {1}", areaR1, circumferenceR1);

            // Rectangle 2 => R2
            double lengthR2 = 2.5;
            double widthR2 = 5.5;
            Rectangle R2 = new Rectangle(lengthR1, widthR1);

            double areaR2 = R2.CalculateArea();
            double circumferenceR2 = R2.CalculateCircumference();
            Console.WriteLine("\n\t*** Rectangle 2 ***");
            Console.WriteLine("\nLength: {0} \nWidth: {1}", lengthR2, widthR2);
            Console.WriteLine("\n\tArea: {0} \n\tCircumference: {1}", areaR2, circumferenceR2);


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }

    public class Rectangle
    {
        // Fields
        #region
        // Instance variables
        private double _length = 0.0;
        private double _width = 0.0;
        #endregion

        // Constructors
        #region
        public Rectangle(double width, double length)
        {
            _length = length;
            _width = width;
        }
        #endregion

        // Methods
        #region
        public double CalculateArea()
        {
            double area = _length * _width;
            return (area);
        }

        public double CalculateCircumference()
        {
            double circumference = (_length + _width) * 2;
            return (circumference);
        }
        #endregion
    }

}
