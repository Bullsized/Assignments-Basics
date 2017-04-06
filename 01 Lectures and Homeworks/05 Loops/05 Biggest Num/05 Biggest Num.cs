using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Biggest_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            var digits = int.Parse(Console.ReadLine());

            var maxNumber = int.MinValue;

            if (digits <= 0)
            {
                Console.WriteLine(digits);
            }
            else
            {
                for (int i = 0; i < digits; i++)
                {
                    var num = int.Parse(Console.ReadLine());
                    if (num > maxNumber)
                    {
                        maxNumber = num;
                    }
                }
                Console.WriteLine(maxNumber);
            }
        }
    }
}
