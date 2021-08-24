﻿using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                int x, y;
                List<string> food = new List<string> { };
                bool status = false;
                Customer User = new Customer();
                Resturant Resturant = new Resturant();

                Console.WriteLine("Welcome To Foodie App");
                Console.WriteLine("If you are a Customer, Enter 1 .");
                Console.WriteLine("If You are Resturant Manager, Enter 2");
                Console.WriteLine("Enter 3 to Exit");
                x = Convert.ToInt32(Console.ReadLine());


                //For Customers
                if (x == 1)
                {
                    Console.WriteLine("For new login, Enter 1");
                    Console.WriteLine("For Existing User, Enter 2");
                    y = Convert.ToInt32(Console.ReadLine());

                    //New User
                    if (y == 1)
                    {
                        Console.WriteLine("Enter your Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter your Address");
                        string address = Console.ReadLine();
                        Console.WriteLine("Enter Nearest Landmark");
                        string landmark = Console.ReadLine();
                        Console.WriteLine("Enter your Phone Number");
                        long phone = Convert.ToInt64(Console.ReadLine());

                        status = User.AddCustomer(name, address, landmark, phone);
                        if (!status)
                        {
                            Console.WriteLine("User Already Exist");
                        }
                    }

                    //Existing User
                    else if (y == 2)
                    {
                        Console.WriteLine("Enter your Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter your Phone Number");
                        long phone = Convert.ToInt64(Console.ReadLine());
                        status = User.CheckCredentials(name, phone);
                        if (!status)
                        {
                            Console.WriteLine("Invaild User Name or Phone Number");
                        }
                    }
                    if (status)
                    {
                        if (ResturantService.ResturantList.Count != 0) 
                        {
                            ResturantService.GetAllResturant();
                            Console.WriteLine("Enter Resturant Name");
                            string Resturantname = Console.ReadLine();
                            if (!ResturantService.CheckResturant(Resturantname))
                            {
                                ResturantService.Search(Resturantname);
                                Resturantname = Console.ReadLine();
                            }
                            else
                            {
                                ResturantService.ShowMenu(Resturantname);
                            }
                        }
                        
                        
                    }


                }


                //For Resturant Managers
                else if (x == 2)
                {
                    Console.WriteLine("To add a resturant, Enter Resturant Name");
                    string Rname = Console.ReadLine();
                    Console.WriteLine("Enter Owner/Manager Name");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Enter Phone Number");
                    long Phone = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter 5 Recommended Food Items");

                    for (int i = 0; i < 5; ++i)
                    {
                        string F = Console.ReadLine();
                        food.Add(F);
                    }

                    Resturant.AddResturant(Rname, Name, Phone, food);
                }

                //To Exit
                else
                {
                    loop = false;
                }

            }
        }
    }
}
