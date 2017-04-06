using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Pool_Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal volume = decimal.Parse(Console.ReadLine());
            decimal pipe1 = decimal.Parse(Console.ReadLine());
            decimal pipe2 = decimal.Parse(Console.ReadLine());
            decimal time = decimal.Parse(Console.ReadLine());

            decimal answer = time * pipe1 + time * pipe2;

            if (answer <= volume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                Math.Truncate((answer / volume) * 100),
                Math.Truncate(((time * pipe1) / answer) * 100),
                Math.Truncate(((time * pipe2) / answer) * 100)
                );
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", time, Math.Abs(answer - volume));
            }
        }
    }
}