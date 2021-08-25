using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface IReasturantService
    {
        public bool AddResturant(string name, string address, string landmark, string owner, long phone, List<string> food);
        public void GetAllResturant();
    }
}
