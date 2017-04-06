using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            decimal d = decimal.Parse(Console.ReadLine());
            decimal e = decimal.Parse(Console.ReadLine());
            
            decimal totalKGs = (a * c) + (a * d) + ((a * e) / 1000M);

            if (totalKGs <= b)
            {
                decimal answer = Math.Abs(b - totalKGs);
                Console.WriteLine("{0} kilos of food left.", Math.Floor(answer));
            }
            else
            {
                decimal answer = Math.Abs(totalKGs - b);
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(answer));
            }
        }
    }
}