using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Generirane_na_Pravoagalnici
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (m > 4 * n * n)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int a1 = -n; a1 <= 0; a1++)
                {
                    for (int a2 = -n; a2 <= 0; a2++)
                    {
                        for (int b1 = n; b1 >= 0; b1--)
                        {
                            for (int b2 = n; b2 >= 0; b2--)
                            {
                            //   if ((-n <= a1 && a1 < a2 && a2 <= n) && (-n <= b1 && b1 < b2 && b2 <= n))
                              //  {
                                    if ((Math.Abs(a1) + Math.Abs(a2))*(Math.Abs(b1) + Math.Abs(b2)) >= m)
                                    {
                                        Console.Write($"({a1}, {a2}) ({b1}, {b2}) -> ");
                                        if (a1 != 0 && a2 != 0 && b1 != 0 && b2 != 0)
                                        {
                                            Console.WriteLine(4 * n * n);
                                        }
                                        else
                                        {
                                            Console.WriteLine(2 * n * n);
                                        }
                                    }
                                    
                               // }
                            }
                        }
                    }
                }
            }
        }
    }
}
