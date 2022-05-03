using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank
{
    public class ChangePin
    {
        public BankAccount AuthedAccount { get; set; }

        public void UpdatePin(BankAccount AuthedAccount)
        {
            /*
                       * 1. Ask the user what they want to change their pin to
                       * 2. Need to check if it is allows aka == to 4 numbers
                       * 3. Need to overwrite the current pin and replace with this one.
                       * 4. Confirm that the pin is good.
                       */
           

            Console.WriteLine("What would you like your new PIN to be?");
            string requestedPin = Console.ReadLine();

            if (AuthedAccount.Pin == Int32.Parse(requestedPin))
            {
                Console.WriteLine("You cannot update your pin to your existing pin.");
            }
            if (requestedPin.Length == 4)
            {
                int newPin = Int32.Parse(requestedPin);
                AuthedAccount.Pin = newPin;

                Database database = new Database(AuthedAccount);

                database.Write();

                Console.WriteLine("Your pin has been updated.");
            }
            else
            {
                Console.WriteLine("That is not a valid pin number");
            }
        }
    }
}
