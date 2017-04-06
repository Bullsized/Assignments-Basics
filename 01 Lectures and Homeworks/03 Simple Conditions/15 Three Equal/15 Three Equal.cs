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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int d = a + b + c;


          int hh = d / 60;
            int mm = d % 60;

            if (mm < 10)
            { Console.WriteLine($"{hh}:0{mm}"); }
            else
            { Console.WriteLine($"{hh}:{mm}"); }

        }
    }
}
