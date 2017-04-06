using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която въвежда час и минути от 24-часово денонощие и изчислява колко ще е часът след 15 минути. 
            //Резултатът да се отпечата във формат hh:mm. Часовете винаги са между 0 и 23, а минутите винаги са между 0 и 59. 
            //Часовете се изписват с една или две цифри. Минутите се изписват винаги с по две цифри, с водеща нула когато е необходимо. 

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x<10 && y<10)
            { Console.WriteLine(x + ":" + (y+15)); }
            else if (0<=x && x<23 && 0<=y && y<=44)
            { Console.WriteLine(x + ":" + (y+15)); }
            else if (x <= 22 && y > 44 && y <= 54)
            { Console.WriteLine((x + 1) + ":0" + Math.Abs((60 - (y + 15)))); }
            else if (x <= 22 && y > 44 && y <= 60)
            { Console.WriteLine((x + 1) + ":" + Math.Abs((60 - (y + 15)))); }
            else if (x == 23 && y <= 44)
            { Console.WriteLine(x + ":" + (y+15)); }
            else if (x == 23 && y > 44 && y <= 54)
            { Console.WriteLine("0:0" + Math.Abs((60 - (y + 15)))); }
            else if (x == 23 && y > 44 && y < 60)
            { Console.WriteLine("0:" + Math.Abs((60 - (y + 15)))); }
            else
            { Console.WriteLine("Wrong Input"); }
        }
    }
}