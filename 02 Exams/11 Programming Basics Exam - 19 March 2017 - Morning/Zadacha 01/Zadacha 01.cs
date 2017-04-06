using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());

            decimal frontBack = ((x * x) * 2) - 2.4M;
            decimal sides = ((x * y) * 2) - 4.5M;
            decimal roof = (2 * (x * y)) + (2 * ((x * h) / 2));

            Console.WriteLine("{0:f2}", (frontBack + sides) / 3.4M);
            Console.WriteLine("{0:f2}", roof / 4.3M);
        }
    }
}