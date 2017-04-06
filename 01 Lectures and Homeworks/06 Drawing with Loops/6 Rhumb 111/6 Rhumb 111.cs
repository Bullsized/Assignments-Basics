using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Rhumb_111
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));

                for (int col = 0; col < row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int row = n - 1; row >= 0; row--)
            {
                Console.Write(new string(' ', n - row));

                for (int col = 0; col < row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}