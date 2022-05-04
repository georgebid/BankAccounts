using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyBank
{
    public class Database
    {
        public string Pin { get; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public int NewPin { get; set; }

        public BankAccount AuthedAccount { get; set; }
        public Database(BankAccount account)
        {
            AuthedAccount = account;
        }
        public Database()
        {

        }

        string bankAccounts = @"C:\Users\Georgina.Bidder\.vscode\accounts.csv";
        public List<BankAccount> Read()
        {
            //read the account
            var accounts = new List<BankAccount>();

            if (!File.Exists(bankAccounts))
            {
                Console.WriteLine($"The data file does not exist at {bankAccounts}.");
                return accounts;
            }
            using (var reader = new StreamReader(bankAccounts))
            {
                string record;
                // while there are records to be read:
                while ((record = reader.ReadLine()) != null)
                {
                  //  List<string> accountData = new List<string>();
                    var stringBuilder = new StringBuilder();
                    stringBuilder.Append(record);
                    // temp array to hold each line as it loops
                    string[] tempArray = stringBuilder.ToString().Split(',');

                    BankAccount newBankAccount = new BankAccount(Int32.Parse(tempArray[0]), Int32.Parse(tempArray[1]), Convert.ToDecimal(tempArray[2]));

                    //hold all of the bank accounts pulled out of the database and then return it so it can be used somewhere 
                    accounts.Add(newBankAccount);
                    Console.WriteLine($"Pin: {newBankAccount.Pin}, AccountNumber: {newBankAccount.AccountNumber}, Balance: {newBankAccount.Balance}");
                }
            }
            return accounts;
        } 
        public void Write()
        {
           
            List<String> usersAccounts = new List<string>();

            if (File.Exists(bankAccounts))
            {
                using (StreamReader reader = new StreamReader(bankAccounts))
                {
                    String usersAccount;

                    while ((usersAccount = reader.ReadLine()) != null)
                    {
                        if (usersAccount.Contains(","))
                        {
                            // creates a new array called Split and splits up the data.
                            // "123, 1234, 30000"
                            // Split = ["123", "1234", "30000"];

                            String[] split = usersAccount.Split(',');

                            if (split[0] == AuthedAccount.AccountNumber.ToString())
                            {
                                split[1] = AuthedAccount.Pin.ToString();
                                split[2] = AuthedAccount.Balance.ToString();
                                // join is doing the reverse of split so it can be read by the CSV file again.
                                usersAccount = String.Join(",", split);
                            } 
                        }
                        usersAccounts.Add(usersAccount);
                    }
                }

                using (StreamWriter writer = new StreamWriter(bankAccounts, false))
                {
                    foreach (String account in usersAccounts)
                        writer.WriteLine(account);
                }
            }
        }
       
    }
}
