﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_101
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine("true or false:");
            bool dui = bool.Parse(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && ticket < 3 && dui == false);
            Console.ReadLine();
        }
    }
}
