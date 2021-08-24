using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ConsoleApp3
{
    public static class ResturantService
    {
        public static List<Resturant> ResturantList = new List<Resturant>
        {

        };

        public static bool Duplicate;
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

        public static void GetAllResturant()
        {
            foreach (Resturant resturant in ResturantService.ResturantList)
            {
                Console.WriteLine(resturant.ResturantName);
            }
        }

        public static void ShowMenu(string name)
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

        public static bool CheckResturant(string name)
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

        public static void Search(string name)
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
