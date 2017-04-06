using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int halF = n / 2;
            int doublE = n * 2;
            int minus3 = n - 3;


            Console.Write("/");
            Console.Write(new string('^', halF));
            Console.Write("\\");
            Console.Write(new string('_', doublE - ((2 * halF) + 4)));
            Console.Write("/");
            Console.Write(new string('^', halF));
            Console.WriteLine("\\");

            for (int mid = 0; mid < minus3; mid++)
            {
                Console.Write("|");
                Console.Write(new string(' ', doublE - 2));
                Console.WriteLine("|");
            }

            Console.Write("|");
            Console.Write(new string(' ', halF + 1));
            Console.Write(new string('_', doublE - ((2 * halF) + 4)));
            Console.Write(new string(' ', halF + 1));
            Console.WriteLine("|");

            Console.Write("\\");
            Console.Write(new string('_', halF));
            Console.Write("/");
            Console.Write(new string(' ', doublE - ((2 * halF) + 4)));
            Console.Write("\\");
            Console.Write(new string('_', halF));
            Console.WriteLine("/");
        }
    }
}