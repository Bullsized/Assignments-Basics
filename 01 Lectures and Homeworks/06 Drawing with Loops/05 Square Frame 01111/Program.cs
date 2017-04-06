using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Square_Frame_01111
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 1; i++)
            {
                Console.Write("+");
                for (int g = 0; g < n-2; g++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" +");
            }

            for (int i = 1; i <= n-2; i++)
            {
                Console.Write("|");
                for (int g = 0; g < n - 2; g++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }

            for (int i = 1; i <= 1; i++)
            {
                Console.Write("+");
                for (int g = 0; g < n - 2; g++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" +");
            }
        }
    }
}