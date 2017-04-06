using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('.', 2 * n - 1));
            Console.Write(@"/|\");
            Console.WriteLine(new string('.', 2 * n - 1));
            Console.Write(new string('.', 2 * n - 1));
            Console.Write(@"\|/");
            Console.WriteLine(new string('.', 2 * n - 1));

            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(new string('.', 2 * n - 1 - i));
                Console.Write("*");
                Console.Write(new string('-', i));
                Console.Write("*");
                Console.Write(new string('-', i));
                Console.Write("*");
                Console.WriteLine(new string('.', 2 * n - 1 - i));
            }

            Console.WriteLine(new string('*', 4 * n + 1));
            for (int bot = 0; bot < (4 * n + 1) / 2; bot++)
            {
                Console.Write("*");
                Console.Write(".");
            }
            Console.WriteLine("*");

            Console.WriteLine(new string('*', 4 * n + 1));

        }
    }
}
