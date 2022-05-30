using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank
{
    public class Withdraw
    {
        public BankAccount AuthedAccount { get; set; }
        public void WithdrawMoney(BankAccount AuthedAccount)
        {
            Console.WriteLine("How much money would you like to withdraw?");
            string usersMoney = Console.ReadLine();

            usersMoney = Authentication.ValidEntryCheck(usersMoney);

            if (AuthedAccount.Balance > 0 && AuthedAccount.Balance > Int32.Parse(usersMoney))
            {
                decimal withdrawnAmount = AuthedAccount.Balance - Int32.Parse(usersMoney);
                Console.WriteLine($"here{withdrawnAmount}");
                AuthedAccount.Balance = withdrawnAmount;
                Console.WriteLine($"Your money has been withdrawn from your account. \nYour account balance is {AuthedAccount.Balance}.");
            }
            else
            {
                Console.WriteLine("You do not have sufficient funds.");
            }

            Database database = new Database(AuthedAccount);

            database.Write();
        }
    }
}
