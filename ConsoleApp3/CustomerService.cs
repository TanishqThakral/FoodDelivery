using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class CustomerService: ICustomerService
    {
        private static bool duplicate;
        private static bool login;
        Customer Customer = new Customer();

        public static List<Customer> CustomerList = new List<Customer>
        {

        };

        public static bool CheckDuplicate(long phone)
        {
            foreach (Customer c in CustomerList)
            {
                if (c.PhoneNo == phone)
                {
                    duplicate = true;
                    Console.WriteLine("This Phone Number Already Exist");
                }
            }
            return duplicate;
        }

        public bool CheckCredentials(string name, long phone)
        {
            foreach (Customer c in CustomerList)
            {
                if (c.PhoneNo == phone && c.Name == name)
                {
                    login = true;
                }
            }

            return login;
        }

        public bool AddCustomer(string name, string address, string landmark, long phone)
        {
            duplicate = CheckCredentials(name, phone);
            if (!duplicate)
            {
                Customer customer = Customer.CreateCustomer(name, address, landmark, phone);
                CustomerList.Add(customer);
            }

            return !duplicate;
        }
    }
}
