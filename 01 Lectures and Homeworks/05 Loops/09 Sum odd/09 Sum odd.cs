﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Sum_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a': sum = sum + 1; break;
                    case 'e': sum = sum + 2; break;
                    case 'i': sum = sum + 3; break;
                    case 'o': sum = sum + 4; break;
                    case 'u': sum = sum + 5; break;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
