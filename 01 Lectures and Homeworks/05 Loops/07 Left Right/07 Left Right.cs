using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Left_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislata = int.Parse(Console.ReadLine());
            var sum1 = 0d;
            for (int i = 0; i < chislata; i++)
            {
                sum1 += double.Parse(Console.ReadLine());
            }
            var sum2 = 0d;
            for (int i = 0; i < chislata; i++)
            {
                sum2 += double.Parse(Console.ReadLine());
            }

            var kraino = Math.Abs(sum1 - sum2);
            if (kraino == 0)
            {
                Console.WriteLine("Yes, sum = " + sum1);
            }
            else
            {
                Console.WriteLine("No, diff = " + kraino);
            }

        }
    }
}
