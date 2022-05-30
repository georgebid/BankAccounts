using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank
{
    public class OptionsMenu
    {
        List<string> Options = new List<string>()
        {
            "withdraw",
            "deposit",
            "view balance",
            "change pin",
            "cancel"
        };
        public BankAccount AuthedAccount { get; set; }
        public OptionsMenu(BankAccount account)

        {
            AuthedAccount = account;
        }

        ChangePin changePin = new ChangePin();
        CheckBalance checkBalance = new CheckBalance();
        Deposit deposit = new Deposit();
        Withdraw withdraw = new Withdraw();

        public void Option()
        {
            Console.WriteLine("What would you like to do? \n");

            foreach (string option in Options)
            {
                Console.WriteLine(option);
            }
            //Console.WriteLine("What would you like to do? \n \n - Withdraw \n - Deposit \n - View Balance \n - Change Pin \n - Cancel ");
            string usersChoice = Console.ReadLine().ToLower();

            if (Options.Contains(usersChoice))
            {
                Console.WriteLine($"You have chosen to {usersChoice}");

                //if (choice.ToString() == "View Balance")
                if (usersChoice == "view balance")
                {
                    checkBalance.Balance(AuthedAccount);
                }
                //if (choice.ToString() == "Change Pin")
                if (usersChoice == "change pin")
                {
                    changePin.UpdatePin(AuthedAccount);
                }
                if (usersChoice == "cancel")
                {
                    Console.WriteLine("Transaction cancelled.");
                    Console.Beep();
                }
                if (usersChoice == "deposit")
                {
                    deposit.DepositMoney(AuthedAccount);
                }
                if (usersChoice == "withdraw")
                {
                    withdraw.WithdrawMoney(AuthedAccount);
                }
            }
            else {
                Console.WriteLine("That is not an option.");
            }

        }

        //else if (userInput == "Withdraw")
        //{
        //    Withdraw();
        //}
    }
}
