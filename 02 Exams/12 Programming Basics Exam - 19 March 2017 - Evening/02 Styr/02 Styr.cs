using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Styr
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            decimal d = decimal.Parse(Console.ReadLine());
            decimal e = decimal.Parse(Console.ReadLine());

            decimal x1 = b - (c * 2.4M);
            decimal x2 = x1 + (x1 * 0.1M);
            decimal x3 = Math.Ceiling(x2 / d);
            decimal x4 = x3 * e;

            if (x4 <= a)
            {
                Console.WriteLine("Spent: {0:f2}", x4);
                Console.WriteLine("Left: {0:f2}", a - x4);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", x4 - a);
            }
        }
    }
}