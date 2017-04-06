using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Parall
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+");
            Console.Write(new string('~', n - 2));
            Console.Write("+");
            Console.WriteLine(new string('.', 2 * n + 1));

            for (int top = 0; top < 2*n + 1; top++)
            {
                Console.Write("|");
                Console.Write(new string ('.', top));
                Console.Write("\\");
                Console.Write(new string('~', n - 2));
                Console.Write("\\");
                Console.WriteLine(new string('.', 2 * n - top));
            }

            for (int bot = 0; bot < 2*n + 1; bot++)
            {
                Console.Write(new string('.', bot));
                Console.Write("\\");
                Console.Write(new string('.', 2*n - bot));
                Console.Write("|");
                Console.Write(new string('~', n - 2));
                Console.WriteLine("|");
            }

            Console.Write(new string('.', 2 * n + 1));
            Console.Write("+");
            Console.Write(new string('~', n - 2));
            Console.WriteLine("+");
        }
    }
}