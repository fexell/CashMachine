using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine {
    internal class Person {
        public string Name { get; }
        public string PersonalNumber { get; }
        public decimal Balance { get; }
        public int Pin { get; }
        public Person( string name, string personalNumber, int pin ) {
            Name = name;
            PersonalNumber = personalNumber;
            Pin = pin;
        }
    }
}
