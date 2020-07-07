using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Opdracht4
    {
        public Opdracht4()
        {

            /*
             * Opdracht 7.4:
               Design the class “Circle” for beam storage. Provide 2 constructors. The first constructor creates a new circle with standard dimensions. The second constructor creates a new circle with the entered parameter (radius). You also provide a method to adjust the radius. Then you add 2 methods to calculate the area and the circumference of the circle. Round the results to 2 decimal places.
           */

            Circle C0 = new Circle();
            C0.InitialValues();

            Circle C1 = new Circle();
            // Adjust the radius hier
            double adjustedRadius = 5;
            C1.AdjustRadius(adjustedRadius);
            Console.WriteLine("\nAdjusted Circle Radius: {0}", adjustedRadius);
            Console.WriteLine("\n\tArea: {0} \n\tCircumference: {1}", C1.CalculateArea(), C1.CalculateCircumference());

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }

    public class Circle
    {
        // Fields
        #region
        // Instance variables
        private static double _pi = 3.14;
        private double _radius = 1.0;
        #endregion

        // Constructors
        #region
        public Circle()
        {

        }

        public Circle(double radius)
        {
            _radius = radius;
        }
        #endregion

        // Methods
        #region
        public void InitialValues()
        {
            string initialValues = "Initial Values: \nPi: " + Circle._pi + "\nRadius: " + this._radius;
            Console.WriteLine(initialValues);
        }
        public void AdjustRadius(double radius)
        {
            _radius = radius;
        }
        public double CalculateArea()
        {
            double area = Math.Round(( Circle._pi * Math.Pow(_radius, 2)), 2);
            return (area);
        }

        public double CalculateCircumference()
        {
            double circumference = Math.Round((2 * Circle._pi * _radius), 2);
            return (circumference);
        }
        #endregion
    }

}
