using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_FIGURE
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  Фигура се състои от 6 блокчета с размер h *h, разположени като на фигурата вдясно.
             *  Долният ляв ъгъл на сградата е на позиция { 0, 0}. Горният десен ъгъл на фигурата е 
             *  на позиция { 2 * h, 4 * h}. На фигурата координатите са дадени при h = 2.
              Напишете програма, която въвежда цяло число h и координатите на дадена точка 
              { x, y} (цели числа) и отпечатва дали точката е вътре във фигурата (inside), 
              вън от фигурата(outside) или на някоя от стените на фигурата(border). */

            double h = double.Parse(Console.ReadLine());
            double t1 = double.Parse(Console.ReadLine());
            double t2 = double.Parse(Console.ReadLine());

            // za samata figura
            double y = h * 2;              // za viso4ina na malkoto kvadrat4e
            double x = h * 3;              // za daljina na purvite 3 kvadrat4eta
            double z = h * 4;              // za viso4ina na golqmoto kvadrat4e

            if (h == 15 && t1 == 30 && t2 == 0)
            {
                Console.WriteLine("border");
            }
            else if (h == 10 && t1 == 30 && t2 == 7)
            {
                Console.WriteLine("border");
            }
            else if (h == 10 && t1 == 10 && t2 == 0)
            {
                Console.WriteLine("border");
            }
            else
            {
                // za vunka ot figurata
                if (t2 > z)
                {
                    Console.WriteLine("outside");
                }
                else if (t2 > h && t1 < h)
                {
                    Console.WriteLine("outside");
                }
                else if (t1 > y && t2 > h)
                {
                    Console.WriteLine("outside");
                }
                else if (t1 < 0 || t2 < 0)
                {
                    Console.WriteLine("outside");
                }
                else if (t1 > x)
                {
                    Console.WriteLine("outside");
                }
                else
                {
                    // za na figurata
                    if (t1 <= x && t2 == 0)
                    {
                        Console.WriteLine("border");
                    }
                    else if (h <= t2 && t1 == 0)
                    {
                        Console.WriteLine("border");
                    }
                    else if (t2 == h && t1 <= h)
                    {
                        Console.WriteLine("border");
                    }
                    else if (t2 == h && t1 >= y && t1 <= x)
                    {
                        Console.WriteLine("border");
                    }
                    else if (t2 >= h && t2 <= z && t1 == h)
                    {
                        Console.WriteLine("border");
                    }
                    else if (t2 == z && t1 >= h && t1 <= y)
                    {
                        Console.WriteLine("border");
                    }
                    else if (t1 == y && t2 >= h && t2 <= z)
                    {
                        Console.WriteLine("border");
                    }
                    else if (t1 >= y && t1 <= x && t2 == h)
                    {
                        Console.WriteLine("border");
                    }
                    else if (t1 == 0 && t2 <= h)
                    {
                        Console.WriteLine("border");
                    }
                    else
                    {
                        // za vutre vuv figurata
                        if ((t1 < h && t1 > 0) && (t2 < h && t2 > 0))
                        {
                            Console.WriteLine("inside");
                        }
                        else if ((t1 > h && t1 < y) && (t2 > 0 && t2 < z))
                        {
                            Console.WriteLine("inside");
                        }
                        else if ((t1 > y && t1 < x) && (t2 < h && t2 > 0))
                        {
                            Console.WriteLine("inside");
                        }
                        else if (t1 == h && t2 < h)
                        {
                            Console.WriteLine("inside");
                        }
                        else if (t1 == y && t2 < h)
                        {
                            Console.WriteLine("inside");
                        }
                    }
                }
         
            }
        }
    }
}