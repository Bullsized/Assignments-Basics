using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string prod = Console.ReadLine().ToLower();
            string grad = Console.ReadLine().ToLower();
            double qty = double.Parse(Console.ReadLine());

            if (grad == "sofia")
            {
                if (prod == "coffee")
                {
                    Console.WriteLine(qty * 0.5);
                }
                else if (prod == "water")
                {
                    Console.WriteLine(qty * 0.8);
                }
                else if (prod == "beer")
                {
                    Console.WriteLine(qty * 1.2);
                }
                else if (prod == "sweets")
                {
                    Console.WriteLine(qty * 1.45);
                }
                else if (prod == "peanuts")
                {
                    Console.WriteLine(qty * 1.6);
                }
            }

            else if (grad == "plovdiv")
            {
                if (prod == "coffee")
                {
                    Console.WriteLine(qty * 0.4);
                }
                else if (prod == "water")
                {
                    Console.WriteLine(qty * 0.7);
                }
                else if (prod == "beer")
                {
                    Console.WriteLine(qty * 1.15);
                }
                else if (prod == "sweets")
                {
                    Console.WriteLine(qty * 1.3);
                }
                else if (prod == "peanuts")
                {
                    Console.WriteLine(qty * 1.5);
                }
            }

            else if (grad == "varna")
            {
                if (prod == "coffee")
                {
                    Console.WriteLine(qty * 0.45);
                }
                else if (prod == "water")
                {
                    Console.WriteLine(qty * 0.7);
                }
                else if (prod == "beer")
                {
                    Console.WriteLine(qty * 1.1);
                }
                else if (prod == "sweets")
                {
                    Console.WriteLine(qty * 1.35);
                }
                else if (prod == "peanuts")
                {
                    Console.WriteLine(qty * 1.55);
                }
            } 

            else
            {
                Console.WriteLine("invalid input");
            }

        }
    }
}
