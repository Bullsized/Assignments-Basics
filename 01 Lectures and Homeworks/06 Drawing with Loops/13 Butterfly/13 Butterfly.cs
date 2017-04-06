using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var delenoto = ((2 * (n - 2) + 1) / 2);

            if (n == 3)
            {
                Console.WriteLine(@"*\ /*");
                Console.WriteLine("  @");
                Console.WriteLine(@"*/ \*");
            }
            else if (n == 4)
            {
                Console.WriteLine(@"--\ /--");
                Console.WriteLine(@"**\ /**");
                Console.WriteLine("   @");
                Console.WriteLine(@"**/ \**");
                Console.WriteLine(@"--/ \--");
            }
            else if (n % 2 == 0)
            {
                for (int line = 0; line < delenoto / 2; line++)
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write(@"\");
                    Console.Write(" ");
                    Console.Write("/");
                    Console.WriteLine(new string('-', n - 2));

                    Console.Write(new string('*', n - 2));
                    Console.Write(@"\");
                    Console.Write(" ");
                    Console.Write("/");
                    Console.WriteLine(new string('*', n - 2));
                }
                Console.Write(new string(' ', n - 1));
                Console.WriteLine("@");
                for (int line = 0; line < delenoto / 2; line++)
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write(@"\");
                    Console.WriteLine(new string('*', n - 2));

                    Console.Write(new string('-', n - 2));
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write(@"\");
                    Console.WriteLine(new string('-', n - 2));
                }
            }
            else
            {
                Console.Write(new string('*', n - 2));
                Console.Write(@"\");
                Console.Write(" ");
                Console.Write("/");
                Console.WriteLine(new string('*', n - 2));

                for (int line = 0; line < delenoto / 2 ; line++)
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write(@"\");
                    Console.Write(" ");
                    Console.Write("/");
                    Console.WriteLine(new string('-', n - 2));

                    Console.Write(new string('*', n - 2));
                    Console.Write(@"\");
                    Console.Write(" ");
                    Console.Write("/");
                    Console.WriteLine(new string('*', n - 2));
                }
                Console.Write(new string(' ', n - 1));
                Console.WriteLine("@");
                for (int line = 0; line < delenoto / 2 ; line++)
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write(@"\");
                    Console.WriteLine(new string('*', n - 2));

                    Console.Write(new string('-', n - 2));
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write(@"\");
                    Console.WriteLine(new string('-', n - 2));
                }
                Console.Write(new string('*', n - 2));
                Console.Write("/");
                Console.Write(" ");
                Console.Write(@"\");
                Console.WriteLine(new string('*', n - 2));
            }
        }
    }
}
