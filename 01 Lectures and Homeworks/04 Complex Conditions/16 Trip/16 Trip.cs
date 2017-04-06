using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Trip
{
    class Program
    {
        static void Main(string[] args)
        {


            var money = double.Parse(Console.ReadLine());
            var sezon = Console.ReadLine().ToLower();

            if (money < 10 || money > 5000)
            {
                Console.WriteLine("error");
            }
            else if (money <= 100)
            {
                if (sezon == "summer")
                {
                    var sum100 = money * 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", sum100);
                }
                else if (sezon == "winter")
                {
                    var sum100 = money * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", sum100);
                }
            }
            else if (money <= 1000)
            {
                if (sezon == "summer")
                {
                    var sum100 = money * 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", sum100);
                }
                else if (sezon == "winter")
                {
                    var sum100 = money * 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", sum100);
                }

            }
            else if (money > 1000)
            {
                if (sezon == "summer")
                {
                    var sum100 = money * 0.9;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", sum100);
                }
                else if (sezon == "winter")
                {
                    var sum100 = money * 0.9;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", sum100);
                }
            }
        }
    }
}
