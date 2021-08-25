using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface ICustomerService
    {
        public bool AddCustomer(string name, string address, string landmark, long phone);
        public bool CheckCredentials(string name, long phone);
    }
}
