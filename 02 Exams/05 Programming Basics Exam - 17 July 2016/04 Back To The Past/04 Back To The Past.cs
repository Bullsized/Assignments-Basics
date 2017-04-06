using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int yearsToLive = year - 1800;
            int x = (((yearsToLive / 2) + 1) * 12000); // chetna
            int y = (12000 * (yearsToLive / 2)) + (50 * ((yearsToLive / 2) + 18)); // nechetna           
            decimal z = money - (x + y);

            if (z >= 0)
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", z);
            else
                Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(z));
        }
    }
}