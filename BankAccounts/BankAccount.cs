using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank
{
   public class BankAccount
    {
        // Pin is only 'gettable', once its been assigned we can't set the numbers. These are properties.
        public int Pin { get; set; }
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public int NewPin { get; set; }

        public BankAccount(int accountNum, int pin, decimal initialBalance)
        {
            this.AccountNumber = accountNum;
            this.Pin = pin;
            this.Balance = initialBalance;
        }
        public BankAccount()
        {

        }
        // actions listed out in the requirements - make deposits. This is a method.
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        // action listed out in the requirements - make withdrawals. This is a method.
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }
    }
}
/* Bank rules: has a 3 digit unique bank account number.
     * the balance can be retrieved.
     * it accepts deposits.
     * it accepts withdrawals.
     * the inital balance must be positive.
     * withdrawals cannot results in a negative balance.
     */