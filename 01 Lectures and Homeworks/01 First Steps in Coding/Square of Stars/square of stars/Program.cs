using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_of_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int size = int.Parse(Console.ReadLine());
             string InitialRows = new String('*', size);
             string WhiteSpaces = new String(' ', size - 2);
             Console.WriteLine(InitialRows);

             for (int i = 0; i < size - 2; i = i + 1)
             {
                 Console.Write('*');
                 Console.Write(WhiteSpaces);
                 Console.Write('*');
                 Console.WriteLine();
             }

             Console.WriteLine(InitialRows);  */
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));
            for (int i = 0; i < n - 2; i++)
                Console.Write(new string('*', 1));
            Console.Write(new string(' ', n - 2));
            Console.WriteLine(new string('*', 1));
            Console.WriteLine(new string('*', n));


        }
    }
}