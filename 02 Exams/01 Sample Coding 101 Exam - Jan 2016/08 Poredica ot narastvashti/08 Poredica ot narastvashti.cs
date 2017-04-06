using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Poredica_ot_narastvashti
{
    class Program
    {
        static void Main(string[] args)
        { 
            int n = int.Parse(Console.ReadLine());
            int incrElemnts = 0;
            int start = 0;
            int maxLEnght = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > start)
                {
                    incrElemnts += 1;
                }
                else
                {
                    incrElemnts = 1;
                }

                if (incrElemnts > maxLEnght)
                {
                    maxLEnght = incrElemnts;
                }
                start = num;
            }
            Console.WriteLine(maxLEnght);
        }
    }
}
/*
            int n = int.Parse(Console.ReadLine());
            var x = 0;
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var c = x;
                x = int.Parse(Console.ReadLine());
                if (x > c )
                {
                    sum = 1 + i;
                }
                else
                {
                sum = 1;
                }
            }
            Console.WriteLine(sum); */
