using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MyBank
{
    public class Authentication
    {
        public List<BankAccount> Accounts { get; set; }
        public BankAccount AuthenticatedAccount { get; set; }

        public Authentication(List<BankAccount> accounts)
        {
            Accounts = accounts;
        }
        public void Authenticate()
        {
            BankAccount selectedAccount = new BankAccount();

            Console.WriteLine("Please enter your account number: ");
            string accountNumber = Console.ReadLine();

            foreach (BankAccount account in Accounts)
            {
                if (account.AccountNumber == Int32.Parse(accountNumber))
                {
                    selectedAccount = account;
                }
                //else
                //{
                //    Console.WriteLine("Access denied.");
                //    System.Environment.Exit(1);
                //}
            }
            if (selectedAccount.AccountNumber != Int32.Parse(accountNumber))
            {
                Console.WriteLine("Access denied.");
                System.Environment.Exit(1);
            }
            Console.WriteLine("Please enter your pin number: ");

            int attempts = 1;

            while (attempts <= 3)
            {
                string pinNumber = Console.ReadLine();
                if (Int32.Parse(pinNumber) == selectedAccount.Pin)
                {
                    Console.WriteLine("\nAccess granted.\n");
                    AuthenticatedAccount = selectedAccount;
                    break;
                }
                else
                {
                    Console.WriteLine($"Incorrect pin. You have {3 - attempts} more attempts.");
                    attempts++;
                    if (attempts > 3)
                    {
                        Console.WriteLine("blocked.");
                    }
                }
            }
        }
        public static string ValidEntryCheck(string usersEntry)
        {
            //while (!Int32.TryParse(usersEntry, out int invalidEntry))
            //{
            //    Console.WriteLine("Error - write only numbers");
            //    string newUsersEntry = Console.ReadLine();

            //}
          
            Regex acceptedEntry = new Regex(@"^[0-9]*$");
            
            while(!acceptedEntry.IsMatch(usersEntry))
            {
                Console.WriteLine("Invalid, try again.");
                usersEntry = Console.ReadLine();
            } 
            return usersEntry;
        }
    }
}
