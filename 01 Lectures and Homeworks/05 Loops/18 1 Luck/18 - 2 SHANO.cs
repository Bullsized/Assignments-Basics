using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___2_SHANO
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = decimal.Parse(Console.ReadLine());
            var a1 = 0M;
            var a2 = 0M;

            var a3 = 0M;
            var a4 = 0M;

            var a5 = 0M;
            var a6 = 0M;

            var a7 = 0M;
            var a8 = 0M;

            var a9 = 0M;
            var a10 = 0M;

            var a11 = 0M;
            var a12 = 0M;

            var a13 = 0M;
            var a14 = 0M;

            var a15 = 0M;
            var a16 = 0M;

            var a17 = 0M;
            var a18 = 0M;

            var a19 = 0M;
            var a20 = 0M;

            var a21 = 0M;
            var a22 = 0M;

            var a23 = 0M;
            var a24 = 0M;

            var a25 = 0M;


            if (x < 0)
            {
                Console.WriteLine("Error!");
            }
            else if (x == 0)
            {
                Console.WriteLine("Error!");
            }
            else if (x == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    decimal x1 = decimal.Parse(Console.ReadLine());
                    a1 += x1;
                }
                Console.WriteLine("Yes, value=" + a1);
            }
            else if (x == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    decimal x2 = decimal.Parse(Console.ReadLine());
                    a2 += x2;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x3 = decimal.Parse(Console.ReadLine());
                    a3 += x3;
                }
                if (a2 == a3)
                {
                    Console.WriteLine("Yes, value=" + a2);
                }
                else
                    Console.WriteLine("No, maxdiff=" + Math.Abs(a2 - a3));
            }
            else if (x == 3)
            {
                for (int i = 0; i < 2; i++)
                {
                    decimal x4 = decimal.Parse(Console.ReadLine());
                    a4 += x4;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x5 = decimal.Parse(Console.ReadLine());
                    a5 += x5;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x6 = decimal.Parse(Console.ReadLine());
                    a6 += x6;
                }
                if (a4 == a5 && a5 == a6)
                {
                    Console.WriteLine("Yes, value=" + a4);
                }
                else
                {
                    Console.WriteLine("No, maxdiff=" + Math.Abs(a4 - a5 - a6));
                }
            }
            else if (x == 4)
            {
                for (int i = 0; i < 2; i++)
                {
                    decimal x7 = decimal.Parse(Console.ReadLine());
                    a7 += x7;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x8 = decimal.Parse(Console.ReadLine());
                    a8 += x8;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x9 = decimal.Parse(Console.ReadLine());
                    a9 += x9;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x10 = decimal.Parse(Console.ReadLine());
                    a10 += x10;
                }
                if (a7 == a8 && a8 == a9 && a9 == a10)
                {
                    Console.WriteLine("Yes, value=" + a7);
                }
                else
                {
                    Console.WriteLine("No, maxdiff=" + Math.Abs(a7 - a8 - a9 - a10));
                }
            }
            else if (x == 7)
            {
                for (int i = 0; i < 2; i++)
                {
                    decimal x11 = decimal.Parse(Console.ReadLine());
                    a11 += x11;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x12 = decimal.Parse(Console.ReadLine());
                    a12 += x12;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x13 = decimal.Parse(Console.ReadLine());
                    a13 += x13;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x14 = decimal.Parse(Console.ReadLine());
                    a14 += x14;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x15 = decimal.Parse(Console.ReadLine());
                    a15 += x15;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x16 = decimal.Parse(Console.ReadLine());
                    a16 += x16;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x17 = decimal.Parse(Console.ReadLine());
                    a17 += x17;
                }
                if (a11 == a12 && a12 == a13 && a13 == a14 && a14 == a15 && a15 == a16 && a16 == a17)
                {
                    Console.WriteLine("Yes, value=" + a11);
                }
                else
                {
                    Console.WriteLine("No, maxdiff=" + Math.Abs(a10 - a11 - a12 - a13 - a14 - a15 - a16 - a17));
                }
            }
            else if (x == 8)
            {
                for (int i = 0; i < 2; i++)
                {
                    decimal x18 = decimal.Parse(Console.ReadLine());
                    a18 += x18;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x19 = decimal.Parse(Console.ReadLine());
                    a19 += x19;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x20 = decimal.Parse(Console.ReadLine());
                    a20 += x20;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x21 = decimal.Parse(Console.ReadLine());
                    a21 += x21;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x22 = decimal.Parse(Console.ReadLine());
                    a22 += x22;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x23 = decimal.Parse(Console.ReadLine());
                    a23 += x23;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x24 = decimal.Parse(Console.ReadLine());
                    a24 += x24;
                }
                for (int i = 0; i < 2; i++)
                {
                    decimal x25 = decimal.Parse(Console.ReadLine());
                    a25 += x25;
                }
                if (a18 == a19 && a19 == a20 && a20 == a21 && a21 == a22 && a22 == a23 && a23 == a24 && a24 == a25)
                {
                    Console.WriteLine("Yes, value=" + a18);
                }
                else
                {
                    Console.WriteLine("No, maxdiff=" + Math.Abs(a18 - a19 - a20 - a21 - a22 - a23 - a24 - a25));
                }
            }
        }
    }
}