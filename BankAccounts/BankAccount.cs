﻿using System;
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
        //public int NewPin { get; set; }

        public BankAccount(int accountNum, int pin, decimal initialBalance)
        {
            this.AccountNumber = accountNum;
            this.Pin = pin;
            this.Balance = initialBalance;
        }
        public BankAccount()
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