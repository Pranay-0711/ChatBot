﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Data.Common;
using System.Configuration;
using BusinessLayer;


namespace UILayer
{
    using DataLayer;

    class UILayer
    {
        public static void Main(string[] args)
        {
            string cpu = "CPU: ";
            string you = "YOU: ";
            Console.WriteLine(cpu + "Hi, you are talking to Philips Helpline");
            string t = Console.ReadLine();
            Console.WriteLine(you + t);
            Console.WriteLine(cpu + "Do you want information about purchasing monitor or solutions?");
            t = Console.ReadLine().ToLower();
            Console.WriteLine(you+"{0}",t);
            bool flag = true;
            int ExitFlag;
            if (t.Contains("monitor"))
            {
                do
                {
                    Console.WriteLine("Do you want monitor based on categories or specifications?");
                    string UserChoice = Console.ReadLine().ToLower();
                    if (UserChoice.Contains("category"))
                    {
                        Console.WriteLine(cpu + "Categories and Series Names are mentioned below:\n");
                        Console.WriteLine(BusinessLogic.GetSerialName());
                        Console.WriteLine(cpu + " Select the Category you want to purchase?");
                        string Category = Console.ReadLine().ToLower();
                        Console.WriteLine(you + "{0}", Category);
                        Console.WriteLine(cpu + "Model Numbers are mentioned below:\n");
                        Console.WriteLine(BusinessLogic.GetModels(Category));
                        Console.WriteLine(cpu + "Select the model you want to enquire about\n");
                        string ModelName = Console.ReadLine();
                        Console.WriteLine(you + "{0}", ModelName);
                        Console.WriteLine((BusinessLogic.GetSpecification(Category, ModelName)));
                    } //************************************
                    else if (UserChoice.Contains("specifications"))
                    {
                        Console.WriteLine(cpu + "Select the monitor of your specifications");
                        string UserQuery = Console.ReadLine().ToLower();
                        Console.WriteLine(you + "{0}", UserQuery);
                        Console.WriteLine(cpu + "Model Numbers according to your specifications are ");
                        Console.WriteLine((BusinessLogic.GetModelOnSpecifications(UserQuery)));
                        Console.WriteLine("\n");
                    }
                    else Console.WriteLine("invalid input");

                    Console.WriteLine("Press 1 to Exit or 0 to enquire more");
                    ExitFlag=Convert.ToInt32(Console.ReadLine());
                    if (ExitFlag == 1) flag = false;
                    else flag = true;

                } while (flag);
            }

            else if (t.Contains("solution"))
            {
         
                Console.WriteLine("Solution information to be given from database");
                Console.ReadLine();
            }
                


        }
          
    }
}
