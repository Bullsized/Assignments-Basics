using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Butterfly_Peperuda
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int half = ((2 * (n - 2) + 1) / 2) - 1;


            for (int top = 3; top <= half + 3; top++)
            {
                if (top % 2 == 1)
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write(@"\ /");
                    Console.WriteLine(new string('*', n - 2));
                }
                else
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write(@"\ /");
                    Console.WriteLine(new string('-', n - 2));
                }
            }
            Console.WriteLine(new string(' ', n - 1) + "@");
            for (int bot = 3; bot <= half + 3; bot++)
            {
                if (bot % 2 == 1)
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write(@"/ \");
                    Console.WriteLine(new string('*', n - 2));
                }
                else
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write(@"/ \");
                    Console.WriteLine(new string('-', n - 2));
                }
            }
        }
    }
}