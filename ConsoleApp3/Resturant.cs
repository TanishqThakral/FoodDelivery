using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{  

    public class Resturant: IReasturant
    {
        public string ResturantName;
        public string Owner;
        public long PhoneNo;
        public List<string> Food = new List<string>();
        private bool Duplicate;
        

        public void AddResturant(string name, string owner, long phone, List<string> food)
        {
            Duplicate = ResturantService.CheckDuplicate(name);            

            if (!Duplicate)
            {
                Resturant resturant = new Resturant
                {
                    ResturantName = name,
                    Owner = owner,
                    PhoneNo = phone,
                    Food = food
                };

                ResturantService.ResturantList.Add(resturant);
                //Console.WriteLine("Resturant Added Successfully!");
            }                        
        }

        

    }
}
