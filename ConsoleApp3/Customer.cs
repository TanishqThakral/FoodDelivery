using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{


    public class Customer 
    {
        public string Name { get; private set; }
        private string address;
        private string landmark;
        public long PhoneNo { get; private set; }

        public Customer CreateCustomer(string name, string address, string landmark, long phone)
        {         
                Customer C1 = new Customer
                {
                    Name = name,
                    address = address,
                    landmark = landmark,
                    PhoneNo = phone
                };             

            return C1;
        }
    }


}
