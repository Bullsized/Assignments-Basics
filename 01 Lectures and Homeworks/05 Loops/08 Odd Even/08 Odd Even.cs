using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Odd_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int chisla = int.Parse(Console.ReadLine());

            var sum1 = 0d;
            var sum2 = 0d;

            for (int i = 0; i < chisla; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sum1 = sum1 + num;
                }
                else
                {
                    sum2 = sum2 + num;
                }
            }
            switch (sum1 == sum2)
            {
                case (true): Console.WriteLine("Yes, sum = " + sum1); break;
                default: Console.WriteLine("No, diff = " + Math.Abs(sum2 - sum1)); break;
            }


        }
    }
}
