﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Between_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x < 100)
                Console.WriteLine("Less than 100");
            else if (100<=x && x<=200)
                Console.WriteLine("Between 100 and 200");
            else
                Console.WriteLine("Greater than 200");
        }
    }
}
