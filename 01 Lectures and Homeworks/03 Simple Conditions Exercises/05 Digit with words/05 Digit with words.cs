﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Digit_with_words
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която въвежда цяло число в диапазона 
            // [0…10] и го изписва с думи на английски език. Ако числото е извън диапазона, изписва “number too big”. 

            int a = int.Parse(Console.ReadLine());

            if (a == 0)
            { Console.WriteLine("zero"); }
            else if (a == 1)
            { Console.WriteLine("one"); }
            else if (a == 2)
            { Console.WriteLine("two"); }
            else if (a == 3)
            { Console.WriteLine("three"); }
            else if (a == 4)
            { Console.WriteLine("four"); }
            else if (a == 5)
            { Console.WriteLine("five"); }
            else if (a == 6)
            { Console.WriteLine("six"); }
            else if (a == 7)
            { Console.WriteLine("seven"); }
            else if (a == 8)
            { Console.WriteLine("eight"); }
            else if (a == 9)
            { Console.WriteLine("nine"); }
            else if (a >= 10)
            { Console.WriteLine("number too big"); }
        }
    }
}
