using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Sumirane_na_Cifrite_na_Chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = 0;

            do
            {
                b = b + (a % 10);
                a /= 10;

            } while (a > 0);

            Console.WriteLine(b);
        }
    }
}