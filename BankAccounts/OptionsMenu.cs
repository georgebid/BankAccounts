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
            AuthedAccount = account;
        }

        ChangePin changePin = new ChangePin();
        CheckBalance checkBalance = new CheckBalance();

        public void Option()
        {
            Console.WriteLine("What would you like to do?");
            string usersChoice = Console.ReadLine();
            
                
                if (Options.Contains(usersChoice))
                {
                    Console.WriteLine($"You have chosen {usersChoice}");

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
                else
                    {
                        Console.WriteLine("That is not an option.");
                    }
                }
                
            //else if (userInput == "Withdraw")
            //{
            //    Withdraw();
            //}
        }
    }
}
