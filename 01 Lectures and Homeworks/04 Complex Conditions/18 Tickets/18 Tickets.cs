using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {


            /*Когато пуснали билетите за Евро 2016, група запалянковци решили да си закупят. Билетите имат две категории с различни цени:
•	VIP – 499.99 лева.
•	Normal – 249.99 лева.
Запалянковците имат определен бюджет, a броят на хората в групата определя какъв процент от бюджета трябва да се задели за транспорт:
 •	От 1 до 4 – 75% от бюджета.
•	От 5 до 9 – 60% от бюджета.
•	От 10 до 24 – 50% от бюджета.
•	От 25 до 49 – 40% от бюджета.
•	50 или повече – 25% от бюджета.
Напишете програма, която да пресмята дали с останалите пари от бюджета могат да си купят билети за избраната категория.
И колко пари ще им останат или ще са им нужни.
Вход
Входът се чете от конзолата и съдържа точно 3 реда:
•	На първия ред е бюджетът – реално число в интервала [1 000.00 ... 1 000 000.00]
•	На втория ред е категорията – „VIP” или „Normal”
•	На третия ред е броят на хората в групата – цяло число в интервала [1 ... 200]
Изход
Да се отпечата на конзолата един ред:
•	Ако бюджетът е достатъчен:
o	“Yes! You have {N} leva left.”– N са останалите пари на групата
•	Ако бюджетът НЕ Е достатъчен:
o	“Not enough money! You need {М} leva.“ – където  М е сумата, която не достига
Сумите трябва да са форматирани с точност до два знака след десетичната запетая. */

            var money = double.Parse(Console.ReadLine());
            var type = Console.ReadLine().ToLower();
            int ppl = int.Parse(Console.ReadLine());

            var biudjet01 = money - (money * 0.75);
            var biudjet02 = money - (money * 0.6);
            var biudjet03 = money - (money * 0.5);
            var biudjet04 = money - (money * 0.4);
            var biudjet05 = money - (money * 0.25);

            var normalBilet = ppl * 249.99;
            var vipBilet = ppl * 499.99;

            if (money < 1000 || money > 1000000)
            {
                Console.WriteLine("error");
            }
            else if (ppl < 1 || ppl > 200)
            {
                Console.WriteLine("error");
            }
            else
            {
                if (ppl >= 1 && ppl <= 4) //b01
                {
                    if (type == "normal")
                    {
                        var nb01 = biudjet01 - normalBilet;
                        if (nb01 >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", nb01);
                        }
                        else if (nb01 < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(nb01));
                        }
                    }
                    else if (type == "vip")
                    {
                        var vb01 = biudjet01 - vipBilet;
                        if (vb01 >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", vb01);
                        }
                        else if (vb01 < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(vb01));
                        }
                    }
                }
                else if (ppl >= 5 && ppl <= 9) //b02
                {
                    if (type == "normal")
                    {
                        var nb02 = biudjet02 - normalBilet;
                        if (nb02 >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", nb02);
                        }
                        else if (nb02 < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(nb02));
                        }

                    }
                    else if (type == "vip")
                    {
                        var vb02 = biudjet02 - vipBilet;
                        if (vb02 >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", vb02);
                        }
                        else if (vb02 < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(vb02));
                        }

                    }
                }
                else if (ppl >= 10 && ppl <= 24) //b03
                {
                    if (type == "normal")
                    {
                        var nb03 = biudjet03 - normalBilet;
                        if (nb03 >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", nb03);
                        }
                        else if (nb03 < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(nb03));
                        }

                    }
                    else if (type == "vip")
                    {
                        var vb03 = biudjet03 - vipBilet;
                        if (vb03 >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", vb03);
                        }
                        else if (vb03 < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(vb03));
                        }
                    }
                }
                else if (ppl >= 25 && ppl <= 49) //b04
                {
                    if (type == "normal")
                    {
                        var nb04 = biudjet04 - normalBilet;
                        if (nb04 >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", nb04);
                        }
                        else if (nb04 < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(nb04));
                        }

                    }
                    else if (type == "vip")
                    {
                        var vb04 = biudjet04 - vipBilet;
                        if (vb04 >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", vb04);
                        }
                        else if (vb04 < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(vb04));
                        }

                    }
                }
                else if (ppl >= 50) //b05
                {
                    if (type == "normal")
                    {
                        var nb05 = biudjet05 - normalBilet;
                        if (nb05 >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", nb05);
                        }
                        else if (nb05 < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(nb05));
                        }
                    }
                    else if (type == "vip")
                    {
                        var vb05 = biudjet05 - vipBilet;
                        if (vb05 >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", vb05);
                        }
                        else if (vb05 < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(vb05));
                        }
                    }
                }
            }
        }
    }
}