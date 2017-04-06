using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inv_Num
{
    class Program
    {
        static void Main(string[] args)
        {

            //Дадено число е валидно, ако е в диапазона[100…200] или е 0.
            //    Да се напише програма, която въвежда цяло число и печата “invalid” ако въведеното число не е валидно. 

            int x = int.Parse(Console.ReadLine());
            var y = (x >= 100 && x <= 200) || x == 0;

            if (!y)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
