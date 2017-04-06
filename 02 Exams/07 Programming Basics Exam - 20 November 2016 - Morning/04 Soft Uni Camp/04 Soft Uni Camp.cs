using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Soft_Uni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal total = 0M;
            decimal type1 = 0M;
            decimal type2 = 0M;
            decimal type3 = 0M;
            decimal type4 = 0M;
            decimal type5 = 0M;

            for (int typeOfTransport = 1; typeOfTransport <= x; typeOfTransport++)
            {
                decimal y = decimal.Parse(Console.ReadLine());

                if (y <= 5)
                {
                    type1+=y;
                }
                else if (6 <= y && y <= 12)
                {
                    type2 += y;
                }
                else if (13 <= y && y <= 25)
                {
                    type3 += y;
                }
                else if (26 <= y && y <= 40)
                {
                    type4 += y;
                }
                else if (41 <= y)
                {
                    type5 += y;
                }
                total += y;
            }
            decimal answer1 = (type1 / total) * 100M;
            decimal answer2 = (type2 / total) * 100M;
            decimal answer3 = (type3 / total) * 100M;
            decimal answer4 = (type4 / total) * 100M;
            decimal answer5 = (type5 / total) * 100M;

            Console.WriteLine("{0:f2}%", answer1);
            Console.WriteLine("{0:f2}%", answer2);
            Console.WriteLine("{0:f2}%", answer3);
            Console.WriteLine("{0:f2}%", answer4);
            Console.WriteLine("{0:f2}%", answer5);

        }
    }
}
