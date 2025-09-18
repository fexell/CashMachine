using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine {
    internal class Customer {
        public const int PASSCODE = 5555;

        public decimal Balance { get; }

        public static void PasscodePrompt() {
            Console.Write( "Enter your pin number: " );
            int inputPasscode = Helpers.IntValidator( Console.ReadLine() );

            while ( inputPasscode != PASSCODE ) {
                Console.Write( "Invalid passcode. Please enter again: " );
                inputPasscode = Helpers.IntValidator( Console.ReadLine() );
            }

            Menu.Run();
        }
    }
}
