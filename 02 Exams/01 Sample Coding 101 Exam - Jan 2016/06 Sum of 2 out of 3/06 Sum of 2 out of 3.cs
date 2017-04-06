using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Sum_of_2_out_of_3
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b == c)
            { Console.WriteLine($"{a} + {b} = {c}"); }
            else if (a + c == b)
            { Console.WriteLine($"{a} + {c} = {b}"); }
            else if (c + b == a)
            { Console.WriteLine($"{c} + {b} = {a}"); }
            else
            { Console.WriteLine("No"); } */
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = 0;

            if (a + b == c)
            {
                result = a + b;
                Console.WriteLine("{0} + {1} = {2}", a, b, result);
            }
            if (b + a == c)
            {
                result = b + a;
                Console.WriteLine("{0} + {1} = {2}", b, a, result);
            }
            if (c + a == b)
            {
                result = c + a;
                Console.WriteLine("{0} + {1} = {2}", c, a, result);
            }
            if (a + c == b)
            {
                result = a + c;
                Console.WriteLine("{0} + {1} = {2}", a, c, result);
            }
            if (b + c == a)
            {
                result = b + c;
                Console.WriteLine("{0} + {1} = {2}", b, c, result);
            }
            if (c + b == a)
            {
                result = c + b;
                Console.WriteLine("{0} + {1} = {2}", c, b, result);
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
