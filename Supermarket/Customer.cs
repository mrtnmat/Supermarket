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

        public Customer (string firstName, string lastName)
        {
            Id = _counter;
            _counter++;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; init; }
        public string FirstName { get; }
        public string LastName { get; }

    }
}
