using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_similar_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();
           
            if (x.ToLower() == y.ToLower())
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}