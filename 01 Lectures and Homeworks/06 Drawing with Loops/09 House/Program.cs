using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_House
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            var counter = 2;
            var counter2 = 2;

            if (x %2 == 0)
            {
                Console.Write(new string('-', (x / 2) - 1));
                Console.Write(new string ('*', 2));
                Console.WriteLine(new string('-', (x / 2) - 1));

                for (int top = 1; top < x / 2; top++)
                {
                    counter = counter + 2;
                    Console.Write(new string('-', (x/2) - counter2));
                    Console.Write(new string('*', counter));
                    Console.WriteLine(new string('-', (x / 2) - counter2));
                    counter2++;
                }
            }
            else
            {
                var negative1 = 3;
                var negative2 = 1;
                Console.Write(new string('-', (x / 2)));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('-', (x / 2)));

                for (int top = 1; top < (x + 1) / 2; top++)
                {
                     Console.Write(new string ('-', (x/2) - negative2));
                    Console.Write(new string('*', negative1));
                    Console.WriteLine(new string('-', (x / 2) - negative2));
                    negative1 = negative1 + 2;
                    negative2 = negative2 + 1;
                }
            }

            for (int bottom = 1; bottom <= x / 2; bottom++)
            {
                Console.Write(new string('|', 1));
                Console.Write(new string('*', x - 2));
                Console.WriteLine(new string('|', 1));
            }
        }
    }
}