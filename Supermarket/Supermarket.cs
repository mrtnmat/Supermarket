using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Supermarket
    {
        readonly public string Chain;
        readonly public string Location;
        List<Customer> _customerList;

        public Supermarket(string chain, string location)
        {
            Chain = chain;
            Location = location;
            _customerList = new List<Customer>();
        }
        public void InsertCustomer(Customer customer)
        {
            _customerList.Add(customer);
        }
        public IReadOnlyCollection<Customer> CustomerList => _customerList.AsReadOnly();
    }
}
