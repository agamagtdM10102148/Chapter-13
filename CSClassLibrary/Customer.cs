using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClassLibrary
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
        }

        public string CompanyName { get; set; }
        public string City { get; set; }

        public List<Order> Orders { get; private set; }
    }
}
