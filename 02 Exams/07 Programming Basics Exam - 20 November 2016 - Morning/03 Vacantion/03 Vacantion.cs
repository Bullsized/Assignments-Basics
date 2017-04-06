using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            string d = Console.ReadLine();

            decimal a2 = 0M;
            decimal b2 = 0M;
            decimal c2 = c * 82.99M;
            decimal ab2 = 0M;
            decimal commission = 0M;
            decimal answer = 0;

            if (d == "train")
            {
                if (a + b >= 50)
                {
                    a2 = a * 24.99M;
                    b2 = b * 14.99M;
                    ab2 = ((a2 + b2) - ((a2+b2) * 0.5M)) * 2M;
                    commission = (ab2 + c2) * 0.1M;
                    answer = ab2 + c2 + commission;
                    Console.WriteLine("{0:f2}", answer);
                }
                else
                {
                    a2 = a * 24.99M;
                    b2 = b * 14.99M;
                    ab2 = (a2 + b2) * 2M;
                    commission = (ab2 + c2) * 0.1M;
                    answer = ab2 + c2 + commission;
                    Console.WriteLine("{0:f2}", answer);
                }
            }
            else if (d == "bus")
            {
                a2 = a * 32.50M;
                b2 = b * 28.50M;
                ab2 = (a2 + b2) * 2M;
                commission = (ab2 + c2) * 0.1M;
                answer = ab2 + c2 + commission;
                Console.WriteLine("{0:f2}", answer);
            }
            else if (d == "boat")
            {
                a2 = a * 42.99M;
                b2 = b * 39.99M;
                ab2 = (a2 + b2) * 2M;
                commission = (ab2 + c2) * 0.1M;
                answer = ab2 + c2 + commission;
                Console.WriteLine("{0:f2}", answer);
            }
            else if (d == "airplane")
            {
                a2 = a * 70.00M;
                b2 = b * 50.00M;
                ab2 = (a2 + b2) * 2M;
                commission = (ab2 + c2) * 0.1M;
                answer = ab2 + c2 + commission;
                Console.WriteLine("{0:f2}", answer);
            }
        }
    }
}