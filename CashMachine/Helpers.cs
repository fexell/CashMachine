using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine {
    internal class Helpers {
        public static int IntValidator( string value ) {
            while( true ) {
                if( int.TryParse( value, out int result ) ) {
                    return result;
                } else {
                    Console.WriteLine( "Invalid integer. Please enter one: " );
                    value = Console.ReadLine();
                }
            }
        }
    }
}
