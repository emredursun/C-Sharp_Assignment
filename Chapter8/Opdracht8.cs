using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace Chapter7
{
    class Opdracht8
    {
        public Opdracht8()
        {

            /*
             * Opdracht 7.8:
               With the Bank account class you can keep track of your bank account. In this class we wish to keep the following information:
               • the state of the account;
               • the limit (you can only go below zero for a certain amount);
               • the number of transactions.
               Provide a constructor who creates a new bank account, where of course the value of all fields is zero. You can set the limit with a
               method. Add a method of depositing money, where you enter the amount to be deposited as a parameter. The state of the account increases by the amount deposited. As a return we then get the new state of the account. Conversely, lowers it picking up an entry is the state of the account. Here too we will see the new state of the account. Also provide a method to print the transactions to the text terminal.
           */

            // The following Constructor gets customer name and his/her initial balance.
            var customer1 = new BankAccount("Emre Dursun", 1000);

            Console.WriteLine($"\nThe account with the number {customer1.Number} was created for {customer1.Owner} with the initial balance of EURO {customer1.Balance}.");

            BACKTOTOP:
            // Ask the user whether to add or eat withdraw the money and also capture wrong inputs
            string userActionChoice;
            do
            {
                Console.Write(
                    "\nWhat action would you like to take with your bank account?" +
                    "\n\n\tMake Deposit => (D) || Make Withdraw => (W) || Get Transactions => (T) : ");
                userActionChoice =Console.ReadLine().ToUpper();
            }
            while (!userActionChoice.Equals("D") && !userActionChoice.Equals("W") && !userActionChoice.Equals("T"));

            // If user action choice is 'Make Deposit'
            if (userActionChoice.Equals("D"))
            {
                // Ask user about the amount of money
                Console.Write("\nHow much would you like to deposit? ");
                decimal depositAmount;
                while (!(decimal.TryParse(Console.ReadLine(), out depositAmount)))
                {
                    Console.Write(
                        "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                        "\nThis is the wrong input. You can't use other characters than numbers." +
                        "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                        "\nPlease fill in an amount that is larger than EURO 0,-: ");
                }
                try
                {
                    customer1.MakeDeposit(depositAmount, DateTime.Now, "New deposit");
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine("\nOOPS! Something went wrong!");
                    Console.WriteLine(argEx.Message);
                }
                finally
                {
                    Console.WriteLine(
                       $"\nThanks for using our services. " +
                       $"\nThe current balance in your account with accountnumber {customer1.Number} is now {customer1.Balance} Euro.");
                }

                TRYAGAIN:
                Console.Write("\n\tWould you like to do any further action on your account? Please enter (Y)es or (N)o : ");
                string userChoice = Console.ReadLine().ToUpper();
                if (userChoice == "Y")
                {
                    Console.Clear();
                    goto BACKTOTOP;
                }
                else if (userChoice == "N")
                {
                    Console.WriteLine("\nThank you for using our services.");
                }
                else
                {
                    Console.WriteLine("\nYou entered an invalid value! Please try again.");
                    goto TRYAGAIN;
                }
            }


            // If user action choice is 'Make Withdraw'
            if (userActionChoice.Equals("W"))
            {
                Console.Write("\nHow much would you like to withdraw? ");
                decimal withdrawelAmount;
                while (!(decimal.TryParse(Console.ReadLine(), out withdrawelAmount)))
                {
                    Console.Write(
                        "\nThis is the wrong input. You can't use other characters than numbers." +
                        "\nPlease fill in an amount that is larger than EURO 0,-: ");
                }

                try
                {
                    customer1.MakeWithdraw(withdrawelAmount, DateTime.Now, "New withdrawel");

                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine("\nOOPS! Something went wrong!");
                    Console.WriteLine(argEx.Message);
                }
                finally
                {
                    Console.WriteLine(
                        $"\nThanks for using our services. " +
                        $"\nThe current balance in your account with accountnumber {customer1.Number} is now {customer1.Balance} Euro.");
                }

            TRYAGAIN:
                Console.Write("\n\tWould you like to do any further action on your account? Please enter (Y)es or (N)o : ");
                string userChoice = Console.ReadLine().ToUpper();
                if (userChoice == "Y")
                {
                    Console.Clear();
                    goto BACKTOTOP;
                }
                else if (userChoice == "N")
                {
                    Console.WriteLine("\nThank you for using our services.");
                }
                else
                {
                    Console.WriteLine("\nYou entered an invalid value! Please try again.");
                    goto TRYAGAIN;
                }
            }

            // If user action choice is 'Get Transactions'
            if (userActionChoice.Equals("T"))
            {
                Console.WriteLine($"\nYou can see all you account transactions below.\n");
                Console.WriteLine(customer1.GetAccountDetails());
                Console.WriteLine($"The new balance in your account for accountnumber {customer1.Number} is EURO {customer1.Balance}.");

            TRYAGAIN:
                Console.Write("\n\tWould you like to do any further action on your account? Please enter (Y)es or (N)o : ");
                string userChoice = Console.ReadLine().ToUpper();
                if (userChoice == "Y")
                {
                    Console.Clear();
                    goto BACKTOTOP;
                }
                else if (userChoice == "N")
                {
                    Console.WriteLine("\nThank you for using our services.");
                }
                else
                {
                    Console.WriteLine("\nYou entered an invalid value! Please try again.");
                    goto TRYAGAIN;
                }
            }


            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }

    public class BankAccount
    {
        #region Properties
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var transaction in allTransactions)
                {
                    balance += transaction.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 12345678;

        private List<Transaction> allTransactions = new List<Transaction>();
        #endregion

        #region Constructors
        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "First deposit!");
            Number = ("NL11 INGB " + accountNumberSeed.ToString());
            accountNumberSeed++;
        }
        #endregion

        #region Methods
        public void MakeDeposit(decimal amount, DateTime transactionDate, string transactionDetails)
        {
            if (amount <= 0)
            {
                throw new ArgumentException(
                    "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                    "\nThe amount you'd like to deposit, should exceed the amount of EURO 0.00 ." +
                    "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            var deposit = new Transaction(amount, transactionDate, transactionDetails);
            allTransactions.Add(deposit);
        }

        public void MakeWithdraw(decimal amount, DateTime transactionDate, string transactionDetails)
        {
            if (amount <= 0)
            {
                throw new ArgumentException(
                    "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                    "\nThe amount you'd like to withdraw, should exceed the amount of EURO 0.00 ." +
                    "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            if ((Balance - amount) < 0)
            {
                throw new ArgumentException(
                    "\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                    "\nThe amount you'd like to withdraw is too large." +
                    "\nThe current balance on your account is " + Balance +
                    "\nPlease try to withdraw an amount that is equal to or less than your balance!" +
                    "\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            var withdrawel = new Transaction(-amount, transactionDate, transactionDetails);
            allTransactions.Add(withdrawel);
        }

        public string GetAccountDetails()
        {
            var transactionsReport = new StringBuilder();
            transactionsReport.AppendLine("Date\t\t\tAmount\t\tTransaction Details");
            foreach (var transaction in allTransactions)
            {
                transactionsReport.AppendLine($"{transaction.TransactionDate.ToShortDateString()}\t\t{ transaction.Amount}\t\t{transaction.TransactionDetails}");

            }
            return transactionsReport.ToString();
        }
        #endregion
    }

    class Transaction
    {
        #region Properties
        public decimal Amount { get; }
        public DateTime TransactionDate { get; }
        public string TransactionDetails { get; }
        #endregion

        #region Constructors
        public Transaction(decimal amount, DateTime transactionDate, string transactionDetails)
        {
            Amount = amount;
            TransactionDate = transactionDate;
            TransactionDetails = transactionDetails;
        }
        #endregion
    }

}