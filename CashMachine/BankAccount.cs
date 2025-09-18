using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine {
    internal class BankAccount {
        public const string CURRENCY = "SEK";
        public static decimal Balance { get; } = Customer.ActiveCustomer.Balance;
        public static void ShowBalance () {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine( $"\nYou have {Balance} {CURRENCY}" );
            Console.ResetColor();
        }
    }
}
