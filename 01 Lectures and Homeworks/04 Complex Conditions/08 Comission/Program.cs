using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Comission
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Фирма дава следните комисионни на търговците си според града, в който работят и обема на продажбите s:
            //Град    0 ≤ s ≤ 500 500 < s ≤ 1 000 1 000 < s ≤ 10 000  s > 10 000
            //Sofia   5 % 7 % 8 % 12 %
            //Varna   4.5 % 7.5 % 10 % 13 %
            //Plovdiv 5.5 % 8 % 12 % 14.5 %
            //Напишете конзолна програма, която чете име на град (стринг)и обем на продажби(десетично число) и изчислява и извежда размера на търговската 
            //комисионна според горната таблица.Резултатът да се изведе закръглен с 2 цифри след десетичната точка.
            // При невалиден град или обем на продажбите(отрицателно число) да се отпечата “error”. Примери:
            //вход    изход       вход    изход       вход    изход       вход    изход
            //Sofia
            //1500    120.00      Plovdiv
            //499.99  27.50       Varna
            //3874.50 387.45      Kaspichan
            //- 50 error

            var grad = Console.ReadLine().ToLower();
            double s = double.Parse(Console.ReadLine());
            

            if (grad == "sofia")
            {
                if (0 <= s && s <= 500)
                {
                    Console.WriteLine($"{s*0.05:f2}");
                }
                else if (500 < s && s <= 1000)
                {
                    Console.WriteLine($"{s * 0.07:f2}");
                }
                else if (1000 < s && s <= 10000)
                {
                    Console.WriteLine($"{s * 0.08:f2}");
                }
                else if (10000 < s)
                {
                    Console.WriteLine($"{s * 0.12:f2}");
                }
                else if (s < 0)
                {
                    Console.WriteLine("error");
                }
            }
            else if (grad == "varna")
            {
                if (0 <= s && s <= 500)
                {
                    Console.WriteLine($"{s * 0.045:f2}");
                }
                else if (500 < s && s <= 1000)
                {
                    Console.WriteLine($"{s * 0.075:f2}");
                }
                else if (1000 < s && s <= 10000)
                {
                    Console.WriteLine($"{s * 0.1:f2}");
                }
                else if (10000 < s)
                {
                    Console.WriteLine($"{s * 0.13:f2}");
                }
                else if (s < 0)
                {
                    Console.WriteLine("error");
                }

            }
            else if (grad == "plovdiv")
            {
                if (0 <= s && s <= 500)
                {
                    Console.WriteLine($"{s * 0.055:f2}");
                }
                else if (500 < s && s <= 1000)
                {
                    Console.WriteLine($"{s * 0.08:f2}");
                }
                else if (1000 < s && s <= 10000)
                {
                    Console.WriteLine($"{s * 0.12:f2}");
                }
                else if (10000 < s)
                {
                    Console.WriteLine($"{s * 0.145:f2}");
                }
                else if (s < 0)
                {
                    Console.WriteLine("error");
                }

            }
            else if (grad != "varna" || grad != "sofia" || grad =="plovdiv")
            {
                Console.WriteLine("error");
            }

        }
    }
}
