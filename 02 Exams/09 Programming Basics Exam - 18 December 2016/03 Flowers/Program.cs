using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            string d = Console.ReadLine();
            string e = Console.ReadLine();

            var broiNaCvetqta = 0M;
            var praznichenDen = 0M;
            if (d == "Spring" || d == "Summer")
            {
                if (e == "Y") // holiday
                {
                    if (c > 7) //nad 7 laleta
                    {
                        if (a + b + c > 20) //nad 20 cvetq
                        {
                            broiNaCvetqta = (a * 2.00M) + (b * 4.10M) + (c * 2.50M);
                            praznichenDen = broiNaCvetqta + (broiNaCvetqta * 0.15M);
                            decimal laleta = praznichenDen - (praznichenDen * 0.15M);
                            decimal discount = laleta - (laleta * 0.2M);
                            decimal final = discount + 2;
                            Console.WriteLine("{0:f2}", final);
                        }
                        else // pod 20 cvetq
                        {
                            broiNaCvetqta = (a * 2.00M) + (b * 4.10M) + (c * 2.50M);
                            praznichenDen = broiNaCvetqta + (broiNaCvetqta * 0.15M);
                            decimal laleta = praznichenDen - (praznichenDen * 0.15M);
                            // decimal discount = laleta - (laleta * 0.2M);
                            decimal final = laleta + 2;
                            Console.WriteLine("{0:f2}", final);
                        }
                    }
                    else //pod 7 laleta
                    {
                        if (a + b + c > 20) //nad 20 cvetq
                        {
                            broiNaCvetqta = (a * 2.00M) + (b * 4.10M) + (c * 2.50M);
                            praznichenDen = broiNaCvetqta + (broiNaCvetqta * 0.15M);
                            //  decimal laleta = praznichenDen - (praznichenDen * 0.15M);
                            decimal discount = praznichenDen - (praznichenDen * 0.2M);
                            decimal final = discount + 2;
                            Console.WriteLine("{0:f2}", final);
                        }
                        else // pod 20 cvetq
                        {
                            broiNaCvetqta = (a * 2.00M) + (b * 4.10M) + (c * 2.50M);
                            praznichenDen = broiNaCvetqta + (broiNaCvetqta * 0.15M);
                            //  decimal laleta = praznichenDen - (praznichenDen * 0.15M);
                            // decimal discount = praznichenDen - (praznichenDen * 0.2M);
                            decimal final = praznichenDen + 2;
                            Console.WriteLine("{0:f2}", final);
                        }
                    }
                }
                else if (e == "N") // no holiday
                {
                    if (c > 7) //nad 7 laleta
                    {
                        if (a + b + c > 20) //nad 20 cvetq
                        {
                            broiNaCvetqta = (a * 2.00M) + (b * 4.10M) + (c * 2.50M);
                            //  praznichenDen = broiNaCvetqta + (broiNaCvetqta * 0.15M);
                            decimal laleta = broiNaCvetqta - (broiNaCvetqta * 0.15M);
                            decimal discount = laleta - (laleta * 0.2M);
                            decimal final = discount + 2;
                            Console.WriteLine("{0:f2}", final);
                        }
                        else // pod 20 cvetq
                        {
                            broiNaCvetqta = (a * 2.00M) + (b * 4.10M) + (c * 2.50M);
                            //  praznichenDen = broiNaCvetqta + (broiNaCvetqta * 0.15M);
                            decimal laleta = broiNaCvetqta - (broiNaCvetqta * 0.15M);
                            // decimal discount = laleta - (laleta * 0.2M);
                            decimal final = laleta + 2;
                            Console.WriteLine("{0:f2}", final);
                        }
                    }
                }
                else //pod 7 laleta
                {
                    if (a + b + c > 20) //nad 20 cvetq
                    {
                        broiNaCvetqta = (a * 2.00M) + (b * 4.10M) + (c * 2.50M);
                        //  praznichenDen = broiNaCvetqta + (broiNaCvetqta * 0.15M);
                        // decimal laleta = broiNaCvetqta - (broiNaCvetqta * 0.15M);
                        decimal discount = broiNaCvetqta - (broiNaCvetqta * 0.2M);
                        decimal final = discount + 2;
                        Console.WriteLine("{0:f2}", final);
                    }
                    else // pod 20 cvetq
                    {
                        broiNaCvetqta = (a * 2.00M) + (b * 4.10M) + (c * 2.50M);
                        //  praznichenDen = broiNaCvetqta + (broiNaCvetqta * 0.15M);
                        // decimal laleta = broiNaCvetqta - (broiNaCvetqta * 0.15M);
                        // decimal discount = broiNaCvetqta - (broiNaCvetqta * 0.2M);
                        decimal final = broiNaCvetqta + 2;
                        Console.WriteLine("{0:f2}", final);
                    }
                }
            }


            else if (d == "Winter" || d == "Autumn")
            {
                if (e == "Y") // holiday
                {
                    if (b > 10) // nad 10 rozi
                    {
                        if (a + b + c > 20) //nad 20 cvetq
                        {
                            broiNaCvetqta = (a * 3.75M) + (b * 4.50M) + (c * 4.15M);
                            praznichenDen = broiNaCvetqta + (broiNaCvetqta * 0.15M);
                            decimal rozi = praznichenDen - (praznichenDen * 0.15M);
                            decimal discount = rozi - (rozi * 0.2M);
                            decimal final = discount + 2;
                            Console.WriteLine("{0:f2}", final);
                        }
                        else
                        {
                            broiNaCvetqta = (a * 3.75M) + (b * 4.50M) + (c * 4.15M);
                            praznichenDen = broiNaCvetqta + (broiNaCvetqta * 0.15M);
                            decimal rozi = praznichenDen - (praznichenDen * 0.15M);
                            // decimal discount = rozi - (rozi * 0.2M);
                            decimal final = rozi + 2;
                            Console.WriteLine("{0:f2}", final);
                        }
                    }
                    else //pod 10 rozi
                    {
                        if (a + b + c > 20) //nad 20 cvetq
                        {
                            broiNaCvetqta = (a * 3.75M) + (b * 4.50M) + (c * 4.15M);
                            praznichenDen = broiNaCvetqta + (broiNaCvetqta * 0.15M);
                            // decimal rozi = praznichenDen - (praznichenDen * 0.15M);
                            decimal discount = praznichenDen - (praznichenDen * 0.2M);
                            decimal final = discount + 2;
                            Console.WriteLine("{0:f2}", final);
                        }
                        else
                        {
                            broiNaCvetqta = (a * 3.75M) + (b * 4.50M) + (c * 4.15M);
                            praznichenDen = broiNaCvetqta + (broiNaCvetqta * 0.15M);
                            //     decimal rozi = praznichenDen - (praznichenDen * 0.15M);
                            //    decimal discount = rozi - (rozi * 0.2M);
                            decimal final = praznichenDen + 2;
                            Console.WriteLine("{0:f2}", final);
                        }
                    }
                }
                else if (e == "N") // no holiday
                {
                    if (b > 10) //nad 10 rozi
                    {
                        if (a + b + c > 20) //nad 20 cvetq
                        {
                            broiNaCvetqta = (a * 3.75M) + (b * 4.50M) + (c * 4.15M);
                            // praznichenDen = broiNaCvetqta + (broiNaCvetqta * 0.15M);
                            decimal rozi = praznichenDen - (praznichenDen * 0.15M);
                            decimal discount = rozi - (rozi * 0.2M);
                            decimal final = discount + 2;
                            Console.WriteLine("{0:f2}", final);
                        }
                        else //pod 20 cvetq
                        {
                            broiNaCvetqta = (a * 3.75M) + (b * 4.50M) + (c * 4.15M);
                            // praznichenDen = broiNaCvetqta + (broiNaCvetqta * 0.15M);
                            decimal rozi = praznichenDen - (praznichenDen * 0.15M);
                            //  decimal discount = rozi - (rozi * 0.2M);
                            decimal final = rozi + 2;
                            Console.WriteLine("{0:f2}", final);
                        }
                    }
                    else
                    {
                        if (a + b + c > 20) // nad 20 cvetq
                        {
                            broiNaCvetqta = (a * 3.75M) + (b * 4.50M) + (c * 4.15M);
                            // praznichenDen = broiNaCvetqta + (broiNaCvetqta * 0.15M);
                            //    decimal rozi = praznichenDen - (praznichenDen * 0.15M);
                            decimal discount = broiNaCvetqta - (broiNaCvetqta * 0.2M);
                            decimal final = discount + 2;
                            Console.WriteLine("{0:f2}", final);
                        }
                        else // pod 20 cvetq
                        {
                            broiNaCvetqta = (a * 3.75M) + (b * 4.50M) + (c * 4.15M);
                            // praznichenDen = broiNaCvetqta + (broiNaCvetqta * 0.15M);
                            //  decimal rozi = praznichenDen - (praznichenDen * 0.15M);
                            // decimal discount = rozi - (rozi * 0.2M);
                            decimal final = broiNaCvetqta + 2;
                            Console.WriteLine("{0:f2}", final);
                        }
                    }
                }
            }
        }
    }
}