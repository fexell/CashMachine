using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine {
    internal class Customer {
        public const int PASSCODE = 5555;
        public const string CURRENCY = "SEK";

        static int loginTries = 1;
        public static decimal Balance { get; } = 5000;

        public static void PasscodePrompt() {
            Console.Write( "Enter your pin number: " );
            int inputPasscode = Helpers.PasscodeValidator( Console.ReadLine() );

            while ( inputPasscode != PASSCODE ) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write( "\nInvalid passcode! " );
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write( "Please try again: " );
                Console.ResetColor();

                inputPasscode = Helpers.PasscodeValidator( Console.ReadLine() );

                loginTries++;

                if( loginTries == 3 ) {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine( "\nToo many login attempts (3). Shutting down application!" );
                    Console.ResetColor();

                    Environment.Exit( 0 );
                }
            }

            Menu.Run();
        }

        public static void ShowBalance() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine( $"\nYou have {Balance} {CURRENCY}" );
            Console.ResetColor();
        }
    }
}
