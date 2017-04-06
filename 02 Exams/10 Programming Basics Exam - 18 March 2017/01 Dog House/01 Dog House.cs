using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());

            decimal walls = 2 * (a * (a / 2));
           // decimal rearWall = (((a / 2) * (a / 2)) + ((a / 2) * (b - (a / 2))))/2;
          //  decimal frontWall = ((a / 2) * (a / 2)) - ((a / 5) * (a / 5));
            decimal squares = ((2 * ((a / 2) * (a / 2))) - ((a/5)*(a/5)));
              decimal triangle = (a / 2) * ((b - (a / 2)));
            decimal sides = walls + squares + triangle;
            decimal top = 2 * (a * (a / 2));

            Console.WriteLine("{0:f2}", sides / 3);
            Console.WriteLine("{0:f2}", top / 5);
        }
    }
}