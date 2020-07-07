using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17
{
    class Opdracht4
    {
        public Opdracht4()
        {
            Console.Write("\nOpdracht 17.4: \nThe user must be able to indicate how long the password must be. After which a random password must be generated with numbers, letters and a strange character (!, @, #, $,%, ^, &, *). The generated password must be displayed on the screen. The password must have a minimum of 10 characters and a maximum of 60. \n\nPlease press a key to test the created script...");
            Console.ReadKey();
            Console.Clear();



        TRYAGAIN:
            Random rnd = new Random();
            int rndLength = rnd.Next(10, 61);
            string ascii_letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digits = "0123456789";
            string punctuation = "!\"#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~";

            string allChars = ascii_letters + digits + punctuation;
            char[] allCharacters = allChars.ToCharArray();
            List<char> passWordCharList = new List<char>();

            //char[] passWordChar = 
            //{
            //    '!', '@', '#', '$', '%', '^', '&', '*',
            //    '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
            //    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            //};


            for (int i = 0; i < rndLength; i++)
            {
                int rndChar = rnd.Next(0, allCharacters.Length);
                passWordCharList.Add(allCharacters[rndChar]);
            }

            string password = string.Join("", passWordCharList.ToArray());

            // Output Section
            Console.WriteLine("Generated password: {0}", password);



            //string pangram = "The quick brown fox jumps over the lazy dog";
            //string[] message = pangram.Split(' ');
            //string[] newMessage = new string[message.Length];

            //for (int i = 0; i < message.Length; i++)
            //{
            //    char[] letters = message[i].ToCharArray();
            //    Array.Reverse(letters);
            //    newMessage[i] = new string(letters);
            //}

            //string result = String.Join(" ", newMessage);
            //Console.WriteLine(result);



            //If user would try this Method again
            string userChoice = TryAgain();
            if (userChoice.Equals("Y"))
            {
                Console.Clear();
                goto TRYAGAIN;
            }
            else
            {
                Console.WriteLine("\nPress a button to test another assignment!");
                Console.ReadKey();
            }
        }

        public static string TryAgain()
        {
            Console.WriteLine("\n\tWould you like to try script again?");
            Console.WriteLine("\t\t\t  =====================  ");
            Console.WriteLine("\t\t\t||                     ||");
            Console.WriteLine("\t\t\t||  (Y)es or (Q)uit    ||");
            Console.WriteLine("\t\t\t||                     ||");
            Console.WriteLine("\t\t\t  =====================  ");
            Console.Write("\n\tEnter your option: ");
            string userChoice = Console.ReadLine().ToUpper();
            return userChoice;
        }
    }

}
