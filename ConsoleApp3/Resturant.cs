using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{  

    public class Resturant
    {
        public string ResturantName { get; private set; }
        public string Owner { get; private set; }
        public long PhoneNo { get; private set; }

        public List<string> Food = new List<string>();
        

        public Resturant CreateResturant(string name, string owner, long phone, List<string> food)
        {           
                Resturant resturant = new Resturant
                {
                    ResturantName = name,
                    Owner = owner,
                    PhoneNo = phone,
                    Food = food
                };
            return resturant;
            }                        
        }

        

    }
}
