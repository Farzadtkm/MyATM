using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDICollegeATMMachine {
    public class Customers {
        List<Customer> allCustomers = new List<Customer>();

        public void addCustomer(Customer aCustomer) {
            allCustomers.Add(aCustomer);
        }

        public Customer getCustomer(int index) {
            return allCustomers.ElementAt(index);
        }

    }
}
