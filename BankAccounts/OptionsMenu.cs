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
            "view Balance",
            "change Pin",
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

        public void Option()
        {
            Console.WriteLine("What would you like to do? \n \n - Withdraw \n - Deposit \n - View Balance \n - Change Pin \n - Cancel ");
            string usersChoice = Console.ReadLine();

            if (Options.Contains(usersChoice.ToLower()))
            {
                Console.WriteLine($"You have chosen to {usersChoice}");

                //if (choice.ToString() == "View Balance")
                if (usersChoice == "View Balance")
                {
                    checkBalance.Balance(AuthedAccount);
                }
                //if (choice.ToString() == "Change Pin")
                if (usersChoice == "Change Pin")
                {
                    changePin.UpdatePin(AuthedAccount);
                }
                if (usersChoice == "Cancel")
                {
                    Console.WriteLine("Transaction cancelled.");
                    Console.Beep();
                }
                if (usersChoice == "Deposit")
                {
                    deposit.depositMoney(AuthedAccount);
                }
            }
            else            {
                Console.WriteLine("That is not an option.");
            }

        }

        //else if (userInput == "Withdraw")
        //{
        //    Withdraw();
        //}
    }
}
