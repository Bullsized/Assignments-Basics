using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            string time = Console.ReadLine().ToLower();
            decimal answer = 0M;

            if (n >= 20 && n < 100)
            {
                answer = n * 0.09M;
                Console.WriteLine(answer);
            }
            else if (n >= 100)
            {
                answer = n * 0.06M;
                Console.WriteLine(answer);
            }
            else
            {
                if (time == "day")
                {
                    answer = (n * 0.79M) + 0.70M;
                    Console.WriteLine(answer);
                }
                else if (time == "night")
                {
                    answer = (n * 0.9M) + 0.70M;
                    Console.WriteLine(answer);
                }
            }
        }
    }
}