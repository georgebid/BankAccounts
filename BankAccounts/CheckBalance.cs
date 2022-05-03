using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank
{

    public class CheckBalance
    {
        public BankAccount AuthedAccount { get; set; }

        public void Balance(BankAccount AuthedAccount)
        {
                
            {
                Console.WriteLine($"Your balance is {AuthedAccount.Balance}");
            }
            

        }
    }
}
