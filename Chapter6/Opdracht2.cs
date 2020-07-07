using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Opdracht2
    {
        public Opdracht2()
        {
            /*
             * Opdracht 6.2:
                Schrijf een methode IsWeekend met als resultaat een boolean die aangeeft of de huidige datum in
                het weekend valt.
           */

            IsWeekend();

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }

        static void IsWeekend()
        {
            DateTime date = DateTime.Now;

            string dateToday = date.ToString("d");
            DayOfWeek day = DateTime.Now.DayOfWeek;
            string dayToday = day.ToString();

            // compare strings
            if ((dayToday == DayOfWeek.Saturday.ToString()) || (dayToday == DayOfWeek.Sunday.ToString()))
            {
                Console.WriteLine($"\n\t{dateToday} is a weekend day which is {dayToday}!");
            }
            else
            {
                Console.WriteLine($"\n\t{dateToday} is not a weekend day which is {dayToday}!");
            }
        }
    }
}
