using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Fruit_or_Veg
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Да се напише програма, която въвежда име на продукт и проверява дали е плод или зеленчук.
            //•	Плодовете "fruit" са banana, apple, kiwi, cherry, lemon и grapes
            //•	Зеленчуците "vegetable" са tomato, cucumber, pepper и carrot
            //•	Всички останали са "unknown"

            string x = Console.ReadLine();

            if (x == "banana" || x == "apple" || x == "kiwi" || x == "cherry" || x == "lemon" || x == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (x == "tomato" || x == "cucumber" || x == "pepper" || x == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
           

        }
    }
}
