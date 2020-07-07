using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Chapter8
{
    class Opdracht4
    {
        public Opdracht4()
        {

            /*
             * Opdracht 8.4:
               By using a ping you can check whether a computer can be reached via a network. Find out how to use ping in a C # application and write a program that includes the user must enter an IP address and where it is shown as a result whether or not this address is reachable.
           */

            GetUserInput();

            Console.ReadKey();
        }

        // Check User Input with this method
        public static void GetUserInput()
        {
            string userIPAddress = "";
            try
            {
                Console.Write("\nIP Address: ");
                userIPAddress = Console.ReadLine();
                if(PingHost(userIPAddress) == true) Console.WriteLine($"\n\t{userIPAddress} IP Address is reachable!");
                else Console.WriteLine($"\n\t{userIPAddress} IP Address is NOT reachable!");
            }
            finally
            {
                //If user would try this Method again
                string userChoice = TryAgain();
                if (userChoice.Equals("Y"))
                {
                    Console.Clear();
                    GetUserInput();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }


        // Try Again Method, if user would try the any methods again
        public static string TryAgain()
        {
            Console.WriteLine("\n\tWould you like to try for any other examples?");
            Console.WriteLine("\t\t\t  =====================  ");
            Console.WriteLine("\t\t\t||                     ||");
            Console.WriteLine("\t\t\t||  (Y)es or (Q)uit    ||");
            Console.WriteLine("\t\t\t||                     ||");
            Console.WriteLine("\t\t\t  =====================  ");
            Console.Write("\n\tEnter your option: ");
            string userChoice = Console.ReadLine().ToUpper();
            return userChoice;
        }


        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException ex)
            {
                Console.WriteLine("\n" + ex.Message);
                return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }
    }

}
