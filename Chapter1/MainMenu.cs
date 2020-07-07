using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{

    class MainMenu
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 99)
            {
                Console.Clear();
                Console.Write("Geef het nummer van de opdracht die je uit wilt voeren (1 - 2, 99 = STOP): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        new Opdracht1();
                        break;
                    case 2:
                        new Opdracht2();
                        break;
                    case 99:
                        Console.WriteLine("Bye bye ...");
                        System.Threading.Thread.Sleep(1000);
                        return;
                    default:
                        Console.WriteLine("Ongeldige keuze ...");
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
            }
        }
    }
}
