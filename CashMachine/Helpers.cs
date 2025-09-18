using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CashMachine {
    internal class Helpers {
        public static int IntValidator( string value ) {
            while( true ) {
                if( int.TryParse( value, out int result ) ) {
                    return result;
                } else {
                    Console.Write( "\nInvalid integer. Please enter one: " );
                    value = Console.ReadLine();
                }
            }
        }

        public static int PasscodeValidator( string value ) {
            while( true ) {
                if( int.TryParse( value, out int result ) && value.Length == 4 ) {
                    return result;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine( "\nInvalid passcode. Needs to be at least 4 numbers long.\n" );
                    Console.ResetColor();
                    Console.Write( "Please enter a valid passcode: " );
                    value = Console.ReadLine();
                }
            }
        }

        public static string NameValidator( string value ) {
            while( true ) {
                if( Regex.IsMatch( value, @"^[a-z]+$", RegexOptions.IgnoreCase ) ) {
                    return value;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write( "Invalid name." );
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.ResetColor();
                    Console.Write( "Enter your name: " );
                    value = Console.ReadLine();
                }
            }
        }
    }
}
