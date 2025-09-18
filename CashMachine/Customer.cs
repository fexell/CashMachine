using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CashMachine {
    internal class Customer {
        public static Person? ActiveCustomer { get; set; } = null;

        static int loginTries = 1;

        private static List<Person> Customers = new() {
            new Person( "Felix", "921003-2794", 10000, 5555 )
        };

        public static bool Login() {
            Console.Write( "Enter your name: " );
            string name = Helpers.NameValidator( Console.ReadLine() );

            Person? match = Customers.FirstOrDefault( x => Regex.IsMatch( name, @"^" + x.Name + @"$", RegexOptions.IgnoreCase ) );

            while( match == null ) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write( $"No user by name {name}. " );
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write( "Enter your name again: " );
                Console.ResetColor();
                name = Helpers.NameValidator( Console.ReadLine() );
                match = Customers.FirstOrDefault( x => Regex.IsMatch( name, @"^" + x.Name + @"$", RegexOptions.IgnoreCase ) );
            }

            Console.Write( "Enter your pin: " );
            int passcode = Helpers.PasscodeValidator( Console.ReadLine() );

            while( passcode != match.Pin ) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write( "Wrong pin number. " );
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write( "Enter your pin again: " );
                Console.ResetColor();

                loginTries++;

                passcode = Helpers.PasscodeValidator( Console.ReadLine() );

                if( loginTries == 3 ) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine( "You have entered a pin number 3 times, without success. Exiting program." );
                    Console.ResetColor();
                    Environment.Exit( 0 );
                }
            }

            ActiveCustomer = match;

            return true;
        }
    }
}
