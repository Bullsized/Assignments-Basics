using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Control_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            bool lamp = false;

            for (int cyc1 = 1; cyc1 <= x1; cyc1++)
            {
                for (int cyc2 = x2; cyc2 >= 1; cyc2--)
                {
                    counter++;
                    sum += cyc1 * 2 + cyc2 * 3;
                    if (sum >= control)
                    {
                        lamp = true;
                        Console.WriteLine($"{counter} moves");
                        Console.WriteLine($"Score: {sum} >= {control}");
                        break;
                    }
                }
                if (lamp == true)
                {
                    break;
                }
            }

            if (lamp == false)
            {
                Console.WriteLine($"{counter} moves");
            }
        }
    }
}