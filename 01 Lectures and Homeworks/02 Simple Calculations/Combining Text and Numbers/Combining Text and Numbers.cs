using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combining_Text_and_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // “You are <firstName> <lastName>, a <age>-years old person from <town>”
            
            string name = Console.ReadLine();
           
            string last = Console.ReadLine();
         
            var age = int.Parse(Console.ReadLine());
           
            string town = Console.ReadLine();

            Console.WriteLine($"You are {name} {last}, a {age}-years old person from {town}.");
        }
    }
}