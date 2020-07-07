using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Opdracht1
    {
        public Opdracht1()
        {

            /*
             * Opdracht 7.1:
                Ontwerp een klasse voor de opslag van de gegevens van leerlingen. Sla de
                voornaam, de naam en de klas elk op in een objectvariabele. Geef de klasse een
                constructor waaraan je de voornaam, naam en klas kan meegeven als parameter.
                Maak een methode die de gegevens verandert en een methode die de gegevens weergeeft.
           */

            Student s1 = new Student("Emre", "Dursun", "A102LAB");
            Student s2 = new Student("Murat", "Bilgin", "A101THE");

            Console.WriteLine(s1.GetPersonalData());
            Console.WriteLine();
            Console.WriteLine(s2.GetPersonalData());

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }

    public class Student
    {
        // Fields
        #region
        // Instance variables
        private string _roepnaam;
        private string _achternaam;
        private string _klas;
        #endregion

        // Constructors
        #region
        public Student(string roepnaam, string achternaam, string klas)
        {
            _roepnaam = roepnaam;
            _achternaam = achternaam;
            _klas = klas;
        }
        #endregion

        // Methods
        #region
        public string GetPersonalData()
        {
            var result = "Roepnaam: " + _roepnaam + "\nAchtername: " + _achternaam + "\nKlas: " + _klas;
            return result;
        }
        #endregion
    }
    
}
