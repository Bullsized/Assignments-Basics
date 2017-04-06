using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_Inch_to_Cm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter inches: ");
            var result = double.Parse(Console.ReadLine());
            Console.WriteLine("To cm: " + result * 2.54);
        
        }
    }
}