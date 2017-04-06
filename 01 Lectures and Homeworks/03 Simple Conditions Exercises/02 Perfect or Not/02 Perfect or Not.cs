using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Perfect_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            // Следващата задача от тази тема е да се напише конзолна програма, която въвежда оценка (десетично число) 
            // и отпечатва “Excellent!”, ако оценката е 5.50 или по-висока, или “Not excellent.” в противен случай.

            var grade = double.Parse(Console.ReadLine());

            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }

            else 
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
