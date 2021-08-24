using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface IReasturant
    {
        public void AddResturant(string name, string owner, long phone, List<string> food);
        
    }
}
