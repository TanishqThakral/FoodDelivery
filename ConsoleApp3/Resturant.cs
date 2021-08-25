using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{  

    public class Resturant: BasicInfo
    {
        public string ResturantName { get; private set; }
        public string Owner { get; private set; }

        public List<string> Food = new List<string>();
        

        public Resturant CreateResturant(string name, string address, string landmark, string owner, long phone, List<string> food)
        {           
                Resturant resturant = new Resturant
                {
                    ResturantName = name,
                    Owner = owner,
                    phoneNo = phone,
                    Food = food,
                    address= address,
                    landmark= landmark
                };
            return resturant;
            }                        
        }

        

    }
}
