using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int three = 0;
            int six = 0;
            int doubleThree = 0;
            int doubleSix = 0;
            for (int top = 0; top < n * 2; top++)
            {
                Console.Write(new string('.', (12 * n - 5) / 2 - three));
                Console.Write(new string('#', 1 + six));
                Console.WriteLine(new string('.', (12 * n - 5) / 2 - three));

                three += 3;
                six += 6;
            }


            for (int mid = 0; mid < ((4 * n) - 2) - (n * 2) - n; mid++)
            {
                Console.Write("|");
                Console.Write(new string('.', 2 + doubleThree));
                Console.Write(new string('#', ((12 * n) - 5) - 6 - doubleSix));
                Console.WriteLine(new string('.', 3 + doubleThree));
                doubleThree += 3;
                doubleSix += 6;
            }

            for (int bot = 1; bot <= n; bot++)
            {
                if (bot == n)
                {
                    Console.Write("@");
                    Console.Write(new string('.', ((12 * n - 5) - (6 * n + 2)) / 2));
                    Console.Write(new string('#', 6 * n + 1));
                    Console.WriteLine(new string('.', (((12 * n - 5) - (6 * n + 2)) / 2) + 1));
                    break;
                }
                Console.Write("|");
                Console.Write(new string('.', ((12 * n - 5) - (6 * n + 2)) / 2));
                Console.Write(new string('#', 6 * n + 1));
                Console.WriteLine(new string('.', (((12 * n - 5) - (6 * n + 2)) / 2)+1));
            }
        }
    }
}