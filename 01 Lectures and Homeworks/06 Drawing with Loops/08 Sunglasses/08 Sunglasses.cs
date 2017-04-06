using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int top = 1; top <= 1; top++)
            {
                Console.Write(new string('*', 2 * n));
                Console.Write(new string(' ', n));
                Console.WriteLine(new string('*', 2 * n));
            }

            for (int middle = 1; middle <= n - 2; middle++)
            {
                if (n % 2 == 0 && middle == (n - 2) / 2)
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string('/', (n + (n - 2))));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('|', n));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('/', (n + (n - 2))));
                    Console.WriteLine(new string('*', 1));
                }
                else if (n % 2 != 0 && middle == ((n-2) /2)+1)
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string('/', (n + (n - 2))));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('|', n));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('/', (n + (n - 2))));
                    Console.WriteLine(new string('*', 1));
                }
                else
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string('/', (n + (n - 2))));
                    Console.Write(new string('*', 1));
                    Console.Write(new string(' ', n));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('/', (n + (n - 2))));
                    Console.WriteLine(new string('*', 1));
                }

            }
            
            for (int top = 1; top <= 1; top++)
            {
                Console.Write(new string('*', 2 * n));
                Console.Write(new string(' ', n));
                Console.WriteLine(new string('*', 2 * n));
            }
        }
    }
}
