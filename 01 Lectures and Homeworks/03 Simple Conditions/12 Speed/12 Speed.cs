using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която въвежда скорост (десетично число) и отпечатва информация за скоростта. 
            //При скорост до 10 (включително) отпечатайте “slow”. При скорост над 10 и до 50 отпечатайте “average”. При скорост над 50 и до 150 отпечатайте “fast”. 
            // При скорост над 150 и до 1000 отпечатайте “ultra fast”. При по-висока скорост отпечатайте “extremely fast”. 

            float x = float.Parse(Console.ReadLine());

            if (x<=10)
            { Console.WriteLine("slow"); }
            else if (10<=x && x<=50)
            { Console.WriteLine("average"); }
            else if (50<x && x<=150)
            { Console.WriteLine("fast"); }
            else if (150<x && x<=1000)
            { Console.WriteLine("ultra fast"); }
            else
            { Console.WriteLine("extremely fast"); }
        }
    }
}