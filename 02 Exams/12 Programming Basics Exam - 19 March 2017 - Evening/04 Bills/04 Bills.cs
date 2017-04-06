using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal months = decimal.Parse(Console.ReadLine());
            decimal electr = 0M;
            decimal water = 20 * months;
            decimal inet = 15 * months;
            decimal others = 0M;

            for (int cycle = 0; cycle < months; cycle++)
            {
                decimal elecMoney = decimal.Parse(Console.ReadLine());

                electr += elecMoney;
                others += (20 + 15 + elecMoney) + ((20 + 15 + elecMoney) * 0.2M);

            }

            decimal average = (electr + water + inet + others) / months;

            Console.WriteLine("Electricity: {0:f2} lv", electr);
            Console.WriteLine("Water: {0:f2} lv", water);
            Console.WriteLine("Internet: {0:f2} lv", inet);
            Console.WriteLine("Other: {0:f2} lv", others);
            Console.WriteLine("Average: {0:f2} lv", average);
        }
    }
}