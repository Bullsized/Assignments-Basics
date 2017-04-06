using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Rekolta
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double ttlGrape = x * y;
            double wine = (ttlGrape * 0.4) / 2.5;
            if (wine >= z)
            {
                var toWhom = ((wine - z) / workers);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Truncate(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wine - z), Math.Ceiling(toWhom));
            }
            else if (wine < z)
            {
                var lack = Math.Abs(wine - z);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Truncate(lack));
            }

        }
    }
}