using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter4
{
    class MainMenu
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 99)
            {
                Console.Clear();
                Console.Write("Geef het nummer van de opdracht die je uit wilt voeren (1 - 16, 99 = STOP): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 8:
                        new Opdracht8();
                        break;
                    case 10:
                        new Opdracht10();
                        break;
                    case 15:
                        new Opdracht15();
                        break;
                    case 99:
                        Console.WriteLine("Bye bye ...");
                        System.Threading.Thread.Sleep(1000);
                        return;
                    default:
                        // Show for 1 second a message to make the user aware of an invalid choise and the show then manu again
                        Console.WriteLine("Ongeldige keuze ...");
                        System.Threading.Thread.Sleep(1000);
                        break;
                } 
            }
        }
    }
}
