using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour < 24; hour++)
            {
                for (int minutes = 0; minutes < 60; minutes++)
                {
                    Console.WriteLine($"{hour:D2}:{minutes:D2}");
                }
            }
        }
    }
}
