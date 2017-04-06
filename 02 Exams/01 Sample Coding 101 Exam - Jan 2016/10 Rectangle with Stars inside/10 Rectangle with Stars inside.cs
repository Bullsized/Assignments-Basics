using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Rectangle_with_Stars_inside
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var middle = (n / 2) + 1;
            var shmiddle = (n / 2) + 1;

            if (n == 2)
            {
                Console.WriteLine("%%%%");
                Console.WriteLine("%**%");
                Console.WriteLine("%%%%");
            }
            else
            {
                Console.WriteLine(new string('%', 2 * n));


                if (n % 2 != 0)
                {
                    for (int mid = 1; mid < n; mid++)
                    {
                        if (middle == mid)
                        {
                            Console.Write("%");
                            Console.Write(new string(' ', (n - 2)));
                            Console.Write("**");
                            Console.Write(new string(' ', (n - 2)));
                            Console.WriteLine("%");
                        }
                        Console.Write("%");
                        Console.Write(new string(' ', 2 * n - 2));
                        Console.WriteLine("%");
                    }
                }
                else if (n % 2 == 0)
                {
                    for (int mid = 2; mid < n; mid++)
                    {
                        if (shmiddle == mid)
                        {
                            Console.Write("%");
                            Console.Write(new string(' ', (n - 2)));
                            Console.Write("**");
                            Console.Write(new string(' ', (n - 2)));
                            Console.WriteLine("%");
                        }
                        Console.Write("%");
                        Console.Write(new string(' ', 2 * n - 2));
                        Console.WriteLine("%");
                    }
                }
                Console.WriteLine(new string('%', 2 * n));
            }
        } 
    }
}