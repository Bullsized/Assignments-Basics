using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Rhumb
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // sredata na romba

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));

                for (int column = 0; column < row; column++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int row = n - 1; row > 0; row--)
            {
                Console.Write(new string(' ', n - row));

                for (int column = 0; column < row; column++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

