using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Larger_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която въвежда две цели числа и отпечатва по-голямото от двете.

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if ( a > b )
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
