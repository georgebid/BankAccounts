using System;
using System.Collections.Generic;
using System.Text;

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
            }
            if (selectedAccount.AccountNumber != Int32.Parse(accountNumber))
            {
                Console.WriteLine("denied");
                System.Environment.Exit(1);
            }
            Console.WriteLine("Please enter your pin number: ");

            int attempts = 1;

            while (attempts <= 3)
            {
                string pinNumber = Console.ReadLine();
                if (Int32.Parse(pinNumber) == selectedAccount.Pin)
                {
                    Console.WriteLine("you have access.");
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
    }
}
