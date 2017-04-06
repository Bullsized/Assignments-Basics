using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            // Първата задача от тази тема е да се напише конзолна програма, 
            // която въвежда оценка (десетично число) и отпечатва “Excellent!”, ако оценката е 5.50 или по-висока.

            var grade = decimal.Parse(Console.ReadLine());

            if (grade >= 5.5m)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}