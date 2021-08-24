using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{


    public class Customer : ICustomer
    {
        public string Name;
        private string Address;
        private string Landmark;
        public long PhoneNo;
        private bool Duplicate;
        private bool Login;


        public bool AddCustomer(string name, string address, string landmark, long phone)
        {
            Duplicate = CustomerService.CheckDuplicate(phone);

            if (!Duplicate)
            {
                Customer C1 = new Customer
                {
                    Name = name,
                    Address = address,
                    Landmark = landmark,
                    PhoneNo = phone
                };
                CustomerService.CustomerList.Add(C1);
            }
            return !Duplicate;
        }

        public bool CheckCredentials(string name, long phone)
        {
            Login = CustomerService.CheckCustomer(name, phone);

            return Login;
        }
    }


}
