using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Bonus_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Дадено е цяло число – брой точки. Върху него се начисляват бонус точки по правилата, описани 
            //по - долу.Да се напише програма, която пресмята бонус точките за това число и общия брой точки с бонусите.
            //•	Ако числото е до 100 включително, бонус точките са 5.
            //•	Ако числото е по-голямо от 100, бонус точките са 20 % от числото.
            //•	Ако числото е по-голямо от 1000, бонус точките са 10 % от числото.
            //•	Допълнителни бонус точки(начисляват се отделно от предходните):
            //o За четно число  +1 т.
            //o За число, което завършва на 5  +2 т.

            int x = int.Parse(Console.ReadLine());
            int y = 0 ;

            if (x % 2 == 0)
            { y = 1; }
            else if (x % 10 == 5)
            { y = 2; }


            if (x <= 100)
            {
                Console.WriteLine(5 + y);
                Console.WriteLine(x + 5 + y);
            }
            else if (100 < x && x < 1000)
            {
                Console.WriteLine((x * 0.2) + y);
                Console.WriteLine(x + (x * 0.2) + y);
            }
            else if (1000 < x)
            {
                Console.WriteLine((x * 0.1) + y);
                Console.WriteLine(x + (x * 0.1) + y );
            }

        }
    }
}
