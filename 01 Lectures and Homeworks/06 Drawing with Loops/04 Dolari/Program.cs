using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Dolari
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int m = 0; m < i; m++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}