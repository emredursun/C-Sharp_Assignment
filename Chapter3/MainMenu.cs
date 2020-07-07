using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
 
    class MainMenu
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 99)
            {
                Console.Clear();
                Console.Write("Geef het nummer van de opdracht die je uit wilt voeren (1 - 22, 99 = STOP): ");
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
                    case 10:
                        new Opdracht10();
                        break;
                    case 11:
                        new Opdracht11();
                        break;
                    case 12:
                        new Opdracht12();
                        break;
                    case 13:
                        new Opdracht13();
                        break;
                    case 14:
                        new Opdracht14();
                        break;
                    case 15:
                        new Opdracht15();
                        break;
                    case 16:
                        new Opdracht16();
                        break;
                    case 17:
                        new Opdracht17();
                        break;
                    case 18:
                        new Opdracht18();
                        break;
                    case 19:
                        new Opdracht19();
                        break;
                    case 20:
                        new Opdracht20();
                        break;
                    case 21:
                        new Opdracht21();
                        break;
                    case 22:
                        new Opdracht22();
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
