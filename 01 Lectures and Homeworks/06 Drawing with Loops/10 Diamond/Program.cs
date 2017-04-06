using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else if (n == 2)
            {
                Console.WriteLine("**");
            }
            else if (n % 2 == 0)
            {
                var counter = 1;
                var counterr = 0;
                var counterrr = 2;
                var mrusen = 1;
                for (int top = 0; top < n / 2; top++)
                {
                    Console.Write(new string('-', (n / 2) - counter));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', counterr));
                    Console.Write(new string('*', 1));
                    Console.WriteLine(new string('-', (n / 2) - counter));

                    counter++;
                    counterr = counterr + 2;
                }

                for (int bottom = 1; bottom <= (n / 2) - 1; bottom++)
                {
                    Console.Write(new string('-', mrusen));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', n - 2 - counterrr));
                    Console.Write(new string('*', 1));
                    Console.WriteLine(new string('-', mrusen));
                    counterrr = counterrr + 2;
                    counterr = counterr - 2;
                    mrusen++;
                }
            }
            else if (n % 2 != 0)
            {
                var nula = 0;
                var edno = 1;
                var dve = 2;
                var tri = 0;
                var osem = 1;
                var x = 1;
                var y = 0;
                var z = 2;

                for (int top = 0; top < (n / 2) + 1; top++)
                {
                    if (top == 0)
                    {
                        Console.Write(new string('-', n / 2));
                        Console.Write("*");
                        Console.WriteLine(new string('-', n / 2));
                    }
                    else
                    {
                        Console.Write(new string('-', (n / 2) - nula - 1));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('-', osem));
                        Console.Write("*");
                        Console.WriteLine(new string('-', (n / 2) - nula - 1));
                        nula++;
                        edno--;
                        tri = 1;
                        osem = osem + 2;
                        dve++;
                    }
                }
                for (int bottom = 0; bottom < n / 2; bottom++)
                {
                    if (bottom < (n/2) - 1)
                    {
                        Console.Write(new string('-', x));
                        Console.Write("*");
                        Console.Write(new string('-', (n - 4 + y)));
                        Console.Write("*");
                        Console.WriteLine(new string('-', x));

                        x++;
                        y = y - 2;
                    }
                    else
                    {
                        Console.Write(new string('-', n / 2));
                        Console.Write("*");
                        Console.WriteLine(new string('-', n / 2));
                    }
                }
            }
        }
    }
}