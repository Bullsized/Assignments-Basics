using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Suma_Galio
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int first = 1;
            int second = 2;
            int third = 3;

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = 1; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (i == first)
                {
                    first += 3;
                    sum1 += currentNumber;
                }
                else if (i == second)
                {
                    second += 3;
                    sum2 += currentNumber;
                }
                else
                {
                    third += 3;
                    sum3 += currentNumber;
                }
            }

            Console.WriteLine($"sum1 = {sum1}");
            Console.WriteLine($"sum2 = {sum2}");
            Console.WriteLine($"sum3 = {sum3}");
        }
    }
}
