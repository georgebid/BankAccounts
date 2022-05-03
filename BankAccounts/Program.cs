using MyBank;
using System;
using System.Collections.Generic;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // read the database
            Database database = new Database();
            List<BankAccount> accounts = database.Read();

            // authenticate the account
            Authentication auth = new Authentication(accounts);
            auth.Authenticate();

            BankAccount authAccount = auth.AuthenticatedAccount;
            //display the options menu
            OptionsMenu menu = new OptionsMenu(authAccount);
            menu.Option();

            //CheckBalance balance = new CheckBalance();
            //balance.Balance();


            
 //Console.WriteLine(authAccount.Balance);
        }
    }
}
