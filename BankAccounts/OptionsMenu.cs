using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank
{
    public class OptionsMenu
    {
        List<string> Options = new List<string>()
        {
            "Withdraw",
            "Deposit",
            "View Balance",
            "Change Pin",
            "Cancel"
        };
        public BankAccount AuthedAccount { get; set; }
        public OptionsMenu(BankAccount account)

        {
            account = AuthedAccount;
        }

        ChangePin changePin = new ChangePin();
        CheckBalance checkBalance = new CheckBalance();

        public string Option()
        {
            Console.WriteLine("What would you like to do?");
            string usersChoice = Console.ReadLine();
            
            foreach (char choice in usersChoice)
            {
                if (Options.Contains(usersChoice))
                {
                    Console.WriteLine($"You have chosen {usersChoice}");
                    if (usersChoice == "View Balance")
                    {
                        checkBalance.Balance(AuthedAccount);
                    }
                    else if (usersChoice == "Change Pin")
                    {
                        changePin.UpdatePin(AuthedAccount);
                    }
                    break;

                }
                if (!Options.Contains(choice.ToString()))
                {
                    Console.WriteLine("That is not an option.");
                    break;
                }

            }
            //else if (userInput == "Withdraw")
            //{
            //    Withdraw();
            //}
           return usersChoice;
        }
    }
}
