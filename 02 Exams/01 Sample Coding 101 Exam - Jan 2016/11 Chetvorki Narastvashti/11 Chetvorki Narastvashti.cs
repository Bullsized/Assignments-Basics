using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Chetvorki_Narastvashti
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            var diff = b - a;

            if (diff >= 3)
            {
                for (int a1 = a; a1 <= b - 3; a1++)
                {
                    for (int a2 = a + 1; a2 <= b - 2; a2++)
                    {
                        for (int a3 = a + 2; a3 <= b - 1; a3++)
                        {
                            for (int a4 = a + 3; a4 <= b; a4 += 1)
                            {
                                if (a <= a1 && a1 < a2 && a2 < a3 && a3 < a4 && a4 <= b)
                                {
                                    Console.WriteLine("{0} {1} {2} {3}", a1, a2, a3, a4);
                                }
                            }
                        }

                    }

                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
