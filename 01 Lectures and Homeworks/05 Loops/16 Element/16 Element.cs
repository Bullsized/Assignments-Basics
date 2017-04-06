using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // kolko chisla broka to4na
            int sum = 0; // sumata na si4ki 4isla
            int max = int.MinValue; //kolkoto da wzeme stoinost

            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine()); //input number sa ti 4islata, koito sa n na broi i gi zadava potrebitelq
                sum += inputNumber; // sumata stava ravna na sbora na si4ki 4isla

                if (inputNumber > max)
                {
                    max = inputNumber;
                }
            }

            if (sum == max * 2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(2 * max - sum));
            }    
            
        }
    }
}
