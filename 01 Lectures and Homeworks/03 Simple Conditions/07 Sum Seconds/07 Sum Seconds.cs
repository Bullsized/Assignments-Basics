using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            // Трима спортни състезатели финишират за някакъв брой секунди (между 1 и 50). Да се напише програма, която въвежда времената на 
            // състезателите и пресмята сумарното им време във формат "минути:секунди". 
            // Секундите да се изведат с водеща нула (2  "02", 7  "07", 35  "35"). Примери:

            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var d = a + b + c;

            if (d < 10)
            {
                Console.WriteLine("0:0" + d);
            }
            else if (10 < d && d <= 59)
            {
                Console.WriteLine("0:" + d);
            }
            else if (60 <= d && d < 70)
            {
                d = d - 60;
                Console.WriteLine("1:0" + d);
            }
            else if (59 <= d && d <= 119)
            {
                d = d - 60;
                Console.WriteLine("1:" + d);
            }
            else if (120 < d && d <130)
            {
                d = d - 120;
                Console.WriteLine("2:0" + d);
            }
            else if (119 <= d && d <= 180)
            {
                d = d - 120;
                Console.WriteLine("2:" + d);
            }
            else if (d == 180)
            {
                Console.WriteLine("3:00");
            }
        }
    }
}
