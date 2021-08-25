using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{


    public class Customer : BasicInfo
    {
        public string Name { get; private set; }
        

        public Customer CreateCustomer(string name, string address, string landmark, long phone)
        {         
                Customer C1 = new Customer
                {
                    Name = name,
                    address = address,
                    landmark = landmark,
                    phoneNo = phone
                };             

            return C1;
        }
    }


}
