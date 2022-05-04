using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank
{
    public class Deposit
    {
        public BankAccount AuthedAccount { get; set; }
        public void depositMoney(BankAccount AuthedAccount)
        {

            Console.WriteLine("How much money would you like to deposit?");
            string usersMoney = Console.ReadLine();


            decimal newTotal = AuthedAccount.Balance + Int32.Parse(usersMoney);
            AuthedAccount.Balance = newTotal;

            Console.WriteLine(newTotal);

            Database database = new Database(AuthedAccount);

            database.Write();

            Console.WriteLine($"Your money has been deposited to your account. \nYour new account balance is {AuthedAccount.Balance}.");
        }
    }
}
//int newPin = Int32.Parse(requestedPin);
//AuthedAccount.Pin = newPin;