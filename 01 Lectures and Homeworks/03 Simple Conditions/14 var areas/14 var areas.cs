using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_var_areas
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();

            if (x == "square")
            { float side = float.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(side * side, 3));
            }
            else if (x == "rectangle")
            {
                float side1 = float.Parse(Console.ReadLine());
                float side2 = float.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(side1 * side2, 3));
            }
            else if (x == "circle")
            {
                float side = float.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * side * side, 3));
            }
            else if (x == "triangle")
            {
                float side1 = float.Parse(Console.ReadLine());
                float side2 = float.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((side1 * side2)/2, 3));
            }
            else
            { Console.WriteLine("wrong input!"); }
               

        }
    }
}
