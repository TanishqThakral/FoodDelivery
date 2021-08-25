using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ConsoleApp3
{
    public class ResturantService: IReasturantService
    {
        public static bool Duplicate;
        Resturant resturant = new Resturant();

        public List<Resturant> ResturantList = new List<Resturant>
        {

        };

        public bool AddResturant(string name, string owner, long phone, List<string> food)
        {
            if (!CheckDuplicate(name))
            {
                Resturant r = resturant.CreateResturant(name, owner, phone, food);
                ResturantList.Add(r);
            }            
            
            return !CheckDuplicate(name);
        }
        
        public static bool CheckDuplicate(string name)
        {
            foreach (Resturant resturant in ResturantList)
            {
                if (resturant.ResturantName == name)
                {
                    Duplicate = true;
                }
            }

            return Duplicate;
        }

        public void GetAllResturant()
        {
            foreach (Resturant resturant in ResturantService.ResturantList)
            {
                Console.WriteLine(resturant.ResturantName);
            }
        }

        public void ShowMenu(string name)
        {
            foreach (Resturant resturant in ResturantService.ResturantList)
            {
                if (resturant.ResturantName.ToUpper() == name.ToUpper())
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(resturant.Food[i]);
                    }
                }
            }
        }

        public bool CheckResturant(string name)
        {
            bool status = false;
            foreach (Resturant resturant in ResturantService.ResturantList)
            {
                if (resturant.ResturantName.ToUpper() == name.ToUpper())
                {
                    status = true;
                }
            }
            return status;
        }

        public void Search(string name)
        {
            IEnumerable<Resturant> ReleatedResturant = from resturant in ResturantList
                                                       where resturant.ResturantName.Contains(name)
                                                       select resturant;
            foreach (Resturant R1 in ReleatedResturant)
            {
                Console.WriteLine(R1.ResturantName);
            }
        }

    }
}
