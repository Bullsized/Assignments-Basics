using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MaxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int stopper = 0;

            for (int purvo = first; purvo <= second; purvo++)
            {
                for (int vtoro = first; vtoro <= second; vtoro++)
                {
                    if (stopper == stop)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write($"<{purvo}-{vtoro}>");
                        stopper += 1;
                    }
                }
                if (stopper == stop) break;
            }
        }
    }
}