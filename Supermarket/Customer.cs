using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Customer
    {
        static private int _counter = 0;
        public readonly int Id;
        public readonly string FirstName, LastName;

        public Customer (string firstName, string lastName)
        {
            Id = _counter;
            _counter++;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
