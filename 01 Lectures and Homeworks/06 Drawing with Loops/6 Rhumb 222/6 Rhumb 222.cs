using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Rhumb_222
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());


            for (int row = 0; row < side; row++)
            {
                Console.Write(new string(' ', side - row -1));
                for (int numberOfSymbols = 0; numberOfSymbols <= row; numberOfSymbols++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
    }
}
