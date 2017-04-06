using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Fortress
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n <= 2)
            {
                Console.WriteLine("Error!");
            }
            else if (n == 3)
            {
                Console.WriteLine(@"/^\/^\"); Console.WriteLine("|    |"); Console.WriteLine(@"\_/\_/");
            }
            else if (n == 4)
            {
                Console.WriteLine(@"/^^\/^^\"); Console.WriteLine("|      |");
                Console.WriteLine("|      |"); Console.WriteLine(@"\__/\__/");

            }
            else if (n % 2 != 0)
            {
                for (int all = 0; all <= n; all++)
                {
                    if (all == 0)
                    {
                        Console.Write("/");
                        Console.Write(new string('^', n/2));
                        Console.Write(@"\");
                        Console.Write(new string('_', ((n - (n/2) - 2)*2)));
                        Console.Write("/");
                        Console.Write(new string('^', n / 2));
                        Console.WriteLine(@"\");
                    }
                    else if (all < n - 2)
                    {
                        Console.Write(new string('|', 1));
                        Console.Write(new string(' ', (2*n)-2));
                        Console.WriteLine(new string('|', 1));
                    }
                    else if (all < n - 1)
                    {
                        Console.Write(new string('|', 1));
                        Console.Write(new string(' ', (n/2) + 1));
                        Console.Write(new string('_', ((n - (n / 2) - 2) * 2)));
                        Console.Write(new string(' ', (n / 2) + 1));
                        Console.WriteLine(new string('|', 1));
                    }
                    else if (all == n )
                    {
                        Console.Write(@"\");
                        Console.Write(new string('_', n / 2));
                        Console.Write("/");
                        Console.Write(new string(' ', ((n - (n / 2) - 2) * 2)));
                        Console.Write(@"\");
                        Console.Write(new string('_', n / 2));
                        Console.WriteLine("/");
                    }
                }
            }
            else if (n % 2 == 0)
            {
                for (int all = 0; all <= n; all++)
                {
                    if (all == 0)
                    {
                        Console.Write("/");
                        Console.Write(new string('^', n / 2));
                        Console.Write(@"\");
                        Console.Write(new string('_', ((n - (n / 2) - 2) * 2)));
                        Console.Write("/");
                        Console.Write(new string('^', n / 2));
                        Console.WriteLine(@"\");
                    }
                    else if (all < n - 2)
                    {
                        Console.Write(new string('|', 1));
                        Console.Write(new string(' ', (2 * n) - 2));
                        Console.WriteLine(new string('|', 1));
                    }
                    else if (all < n - 1)
                    {
                        Console.Write(new string('|', 1));
                        Console.Write(new string(' ', (n / 2) + 1));
                        Console.Write(new string('_', ((n - (n / 2) - 2) * 2)));
                        Console.Write(new string(' ', (n / 2) + 1));
                        Console.WriteLine(new string('|', 1));
                    }
                    else if (all == n)
                    {
                        Console.Write(@"\");
                        Console.Write(new string('_', n / 2));
                        Console.Write("/");
                        Console.Write(new string(' ', ((n - (n / 2) - 2) * 2)));
                        Console.Write(@"\");
                        Console.Write(new string('_', n / 2));
                        Console.WriteLine("/");
                    }
                }
            }

        }
    }
}