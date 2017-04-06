using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Perfect_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - 1 - i));
                Console.Write("*");
                for (int b = 1; b <= i; b++)
                {
                    Console.Write(new string ('-', 1));
                    Console.Write(new string ('*', 1));
                }
                Console.WriteLine();
            }
            for (int m = 1; m <= n - 1; m++)
            {
                Console.Write(new string(' ', m));
                Console.Write("*");
                for (int c = 1; c <= n - 1 - m; c++)
                {
                    Console.Write(new string ('-', 1));
                    Console.Write(new string ('*', 1));
                }
                Console.WriteLine();
            }
        }
    }
}