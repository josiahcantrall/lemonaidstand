using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lemonaidstand
{
    public class Customer
    {
        public Customer(int CustomerTemperment, int GetCustomerDesireToSpend)
        {
            int customerTemperment = CustomerTemperment;
            int getCustomerDesireToSpend = GetCustomerDesireToSpend;

        }

        public int customerTemperment()
        {
            Random random = new Random();
            int CustomerTemperment = random.Next(0, 7);
            return CustomerTemperment;
        }

        public int getCustomerDesireToSpend()
        {
            Random random = new Random();
            int CustomerDesireToSpend = random.Next(0, 7);
            return CustomerDesireToSpend;
        }


        public List<Customer> CreateCustomers(int numberOfCustomers)
        {
           
            List<Customer> customers = new List<Customer>();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Random random = new Random();
                Customer customer = new Customer(random.Next(1, 7), (random.Next(1, 7)));
                customers.Add(customer);

            }
            return customers;


        }
    }
}

