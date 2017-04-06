using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Sum_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int cSTOP = int.Parse(Console.ReadLine());
            int counter = 0;
            bool lamp = false;
            for (int cycle1 = a; cycle1 <= b; cycle1++)
            {
                for (int cycle2 = a; cycle2 <= b; cycle2++)
                {
                    counter++;
                    if (cycle1 + cycle2 == cSTOP)
                    {
                        Console.WriteLine($"Combination N:{counter} ({cycle1} + {cycle2} = {cSTOP})");
                        lamp = true;
                        break;
                    }
                }
                if (lamp == true)
                {
                    break;
                }
            }
            if (lamp == false)
            {
            Console.WriteLine("{0} combinations - neither equals {1}", counter, cSTOP);
            }            
        }
    }
}