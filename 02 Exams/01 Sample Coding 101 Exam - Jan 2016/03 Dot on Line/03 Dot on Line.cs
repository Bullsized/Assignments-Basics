using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dot_on_Line
{
    class Program
    {
        static void Main(string[] args)
        { /*
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            int diff1 = two - point;
            int diff2 = point - one;
            int diff3 = one - point;
            int diff4 = point - two;

            if (one > two)
            {
                if (point <= one && point >= two)
                {
                    Console.WriteLine("in");
                    if (diff3 > diff4)
                    { Console.WriteLine(diff4); }
                    else if (diff3 < diff4)
                    { Console.WriteLine(diff3); }
                }
                else if (point >= one && one >= two)
                { Console.WriteLine("out\n{0}", Math.Abs(diff2)); }
                else if (point <= two && two <= one)
                { Console.WriteLine("out\n{0}", Math.Abs(diff1)); }
            }
            else if (one < two)
            {
                if (point >= one && point <= two)
                {
                    Console.WriteLine("in");
                    if (diff1 > diff2)
                    { Console.WriteLine(diff2); }
                    else if (diff1 < diff2)
                    { Console.WriteLine(diff1); }
                }
                else if (point >= two && two >= one)
                { Console.WriteLine("out\n{0}", Math.Abs(diff4)); }
                else if (point <= one && one <= two)
                { Console.WriteLine("out\n{0}", Math.Abs(diff3)); }
            }
            else if (one == two && point > one)
            {
                Console.WriteLine("out\n{0}", Math.Abs(diff2));
            }
            else if (one == two && point < one)
            {
                Console.WriteLine("out\n{0}", Math.Abs(diff3));
            }
            else if (one == two && point == one)
            {
                Console.WriteLine("in\n0");
            } */
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            if ((x >= a && x <= b) || (x <= a && x >= b))
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
            Console.WriteLine(Math.Min(Math.Abs(x - a), Math.Abs(x - b)));
        }
    }
}