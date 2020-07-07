using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Opdracht5
    {
        public Opdracht5()
        {

            /*
             * Opdracht 7.5:
               Design a class CD for the storage of the title and the performer. The constructor creates a new CD with the entered title and performer. Add two methods to query the contents of the title and performer fields. Add another field that stores the number of songs on the CD. Also provide an accessor method to display the number of songs. Add a method to print all information about the title, performer and number of songs to the terminal
                 window. Provide a clear representation of the information in the terminal window.
           */

            CD CD1 = new CD("Mini World", "Indila", 10);
            CD CD2 = new CD("Unapologetic", "Rihanna", 14);
            Console.WriteLine("\n\t****  CD Details  ****");
            Console.WriteLine(CD1.GetInfoAboutCD());
            Console.WriteLine(CD2.GetInfoAboutCD());

            var CD3 = new CD();
            CD3.Title = "Maya";
            CD3.Artist = "Mabel Matiz";
            CD3.NumberOfSongs = 23;
            Console.WriteLine(CD3.GetInfoAboutCD());

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }

    public class CD
    {
        // Fields
        #region
        // Instance variables
        private string _title;
        private string _performer;
        private int _numberOfSongs;

        public string Title { get => _title; set => _title = value; }
        public string Artist { get => _performer; set => _performer = value; }
        public int NumberOfSongs { get => _numberOfSongs; set => _numberOfSongs = value; }
        #endregion

        // Constructors
        #region
        public CD() { }
        public CD (string title, string performer, int numberOfSongs)
        {
            _title = title;
            _performer = performer;
            _numberOfSongs = numberOfSongs;
        }

        #endregion

        // Methods
        #region
        public string GetInfoAboutCD()
        {
            string result = "The CD " + _title + " from " + _performer + " contains " + _numberOfSongs + " songs.";
            return (result);
        }
        #endregion
    }

}
