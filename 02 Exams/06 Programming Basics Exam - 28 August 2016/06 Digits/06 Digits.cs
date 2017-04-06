using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var newdigit = n;

            var edno = newdigit / 10;    
            var digitOne = edno / 10;   
            var digitTwo = edno - digitOne * 10;
            var digitThree = newdigit - (digitOne * 100) - (digitTwo * 10);

            int en = digitOne + digitTwo; 
            int em = digitOne + digitThree; 

            for (int redove = 0; redove < en; redove++)
            {
                for (int coloni = 0; coloni < em; coloni++)
                {
                    if (newdigit % 5 == 0)
                    {
                        newdigit -= digitOne;
                        Console.Write("{0} ", newdigit);
                    }
                    else if (newdigit % 3 == 0)
                    {
                        newdigit -= digitTwo;
                        Console.Write("{0} ", newdigit);
                    }
                    else
                    {
                        newdigit += digitThree;
                        Console.Write("{0} ", newdigit);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}