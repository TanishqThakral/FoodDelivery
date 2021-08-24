using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class CustomerService
    {
        private static bool Duplicate;
        private static bool Login;

        public static List<Customer> CustomerList = new List<Customer>
        {

        };

        public static bool CheckDuplicate(long phone)
        {
            foreach (Customer c in CustomerList)
            {
                if (c.PhoneNo == phone)
                {
                    Duplicate = true;
                    Console.WriteLine("This Phone Number Already Exist");
                }
            }
            return Duplicate;
        }

        public static bool CheckCustomer(string name, long phone)
        {
            foreach (Customer c in CustomerList)
            {
                if (c.PhoneNo == phone && c.Name == name)
                {
                    Login = true;
                }
            }
            return Login;
        }
    }
}
