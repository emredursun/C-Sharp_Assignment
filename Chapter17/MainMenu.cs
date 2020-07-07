using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace Chapter17
{

    class MainMenu
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 99)
            {
                Console.Clear();
                Console.Write("Enter the number of the assignment you want to execute (1 - 10, 99 = STOP): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        new Opdracht1();
                        break;
                    case 2:
                        new Opdracht2();
                        break;
                    case 3:
                        new Opdracht3();
                        break;
                    case 4:
                        new Opdracht4();
                        break;
                    case 5:
                        new Opdracht5();
                        break;
                    case 6:
                        new Opdracht6();
                        break;
                    case 7:
                        new Opdracht7();
                        break;
                    case 8:
                        new Opdracht8();
                        break;
                    case 9:
                        new Opdracht9();
                        break;
                    case 99:
                        Console.WriteLine("Bye bye ...");
                        System.Threading.Thread.Sleep(1000);
                        return;
                    default:
                        // Show for 1 second a message to make the user aware of an invalid choise and the show then menu again
                        Console.WriteLine("Ongeldige keuze ...");
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
            }
        }
    }
}
