using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine {
    internal class Person {
        public string Name { get; }
        public string PersonalNumber { get; }
        public decimal Balance { get; } = 5000;
        public int Pin { get; }
        public Person( string name, string personalNumber, decimal balance, int pin ) {
            Name = name;
            PersonalNumber = personalNumber;
            Balance = balance;
            Pin = pin;
        }
    }
}
