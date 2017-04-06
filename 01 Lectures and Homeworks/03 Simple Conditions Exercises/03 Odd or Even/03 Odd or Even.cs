using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която въвежда цяло число и печата дали е четно или нечетно.

            var digit = int.Parse(Console.ReadLine());

            if (digit % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }

        }
    }
}