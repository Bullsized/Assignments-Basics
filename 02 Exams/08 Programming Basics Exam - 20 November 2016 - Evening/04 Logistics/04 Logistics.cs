using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cargoCount = decimal.Parse(Console.ReadLine());
            decimal totalTonnage = 0M;

            decimal bus = 0M;
            decimal busTotal = 0M;
            decimal busCount = 0M;

            decimal truck = 0M;
            decimal truckTotal = 0M;
            decimal truckCount = 0M;

            decimal train = 0M;
            decimal trainTotal = 0M;
            decimal trainCount = 0M;

            for (int cycle = 1; cycle <= cargoCount; cycle++)
            {
                decimal tonnage = decimal.Parse(Console.ReadLine());
                if (tonnage <= 3)
                {
                    bus = 200 * tonnage;
                    busTotal += bus;
                    busCount += tonnage;
                }
                else if (4 <= tonnage && tonnage <= 11)
                {
                    truck = 175 * tonnage;
                    truckTotal += truck;
                    truckCount += tonnage;
                }
                else if (12 <= tonnage)
                {
                    train = 120 * tonnage;
                    trainTotal += train;
                    trainCount += tonnage;
                }

                totalTonnage += tonnage;

            }
            decimal average = (busTotal + truckTotal + trainTotal) / totalTonnage;
            Console.WriteLine("{0:f2}", average);

            decimal krai1 = ((busCount / totalTonnage) * 100);
            Console.WriteLine("{0:f2}%", krai1);

            decimal krai2 = ((truckCount / totalTonnage) * 100);
            Console.WriteLine("{0:f2}%", krai2);

            decimal krai3 = ((trainCount / totalTonnage) * 100);
            Console.WriteLine("{0:f2}%", krai3);
        }
    }
}
