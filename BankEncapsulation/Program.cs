using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool anotherTransaction;
            var account = new BankAccount();

            do
            {
                Console.WriteLine("Welcome to Broke People Bank!");
                Console.WriteLine("Would you like to: deposit, withdraw, or view balance?");
                var userResponse = Console.ReadLine().ToLower();
                Console.Clear();


                if (userResponse == "deposit")
                {
                    Console.WriteLine("Enter deposit amount.");
                    var userDeposit = double.Parse(Console.ReadLine());
                    account.Deposit(userDeposit);
                }
                if (userResponse == "withdraw")
                {
                    Console.WriteLine("Enter withdraw amount.");
                    var userWithdraw = double.Parse(Console.ReadLine());
                    account.Withdraw(userWithdraw);
                }
                if (userResponse == "view balance")
                {
                    Console.WriteLine($"Your balance is: {account.GetBalance()}");
                    PressEnter();
                }
                if (userResponse == "balance")
                {
                    Console.WriteLine($"Your balance is: {account.GetBalance()}");
                    PressEnter();
                }

                Console.Clear();

                Console.WriteLine("Would you like to complete another transaction?");
                var transactionResponse = Console.ReadLine().ToLower();
                
                if (transactionResponse == "yes")
                {
                    anotherTransaction = true;
                    Console.Clear();
                } 
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Thank you, have a nice day.");
                    anotherTransaction = false;
                }

            } while (anotherTransaction == true);
            


        }

        private static void PressEnter()
        {
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
