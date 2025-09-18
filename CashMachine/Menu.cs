using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine {
    internal class Menu {
        static Dictionary<int, MenuItem> MenuItems = new() {
            { 0, new MenuItem( "Exit", () => Environment.Exit( 0 ) ) },
            { 3, new MenuItem( "Show Balance", Customer.ShowBalance ) },
        };

        static void DisplayMenu () {
            foreach ( ( int index, MenuItem item ) in MenuItems ) {
                Console.WriteLine( $"{index}. {item.Name}" );
            }
        }

        static void MenuLoop() {
            while( true ) {
                Console.Clear();

                DisplayMenu();

                Console.Write( "> " );
                int input = Helpers.IntValidator( Console.ReadLine() );

                if ( MenuItems.ContainsKey( input ) ) {
                    MenuItems[ input ].Action.Invoke();
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine( "Invalid menu choice. Presss any key to try again..." );
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
        }

        public static void ReturnToMenu() {
            Console.WriteLine( "\nPress any key to return to the menu..." );
            Console.ReadKey();
        }

        public static void Run() {
            MenuLoop();
        }
    }

    internal class MenuItem : Menu {
        public string Name { get; }
        public Action Action { get; }

        public MenuItem ( string name, Action action, bool isReturn = true ) {
            Name = name;

            if( isReturn ) {
                Action = () => {
                    action();

                    Menu.ReturnToMenu();
                };
            } else {
                Action = action;
            }
        }
    }
}
