using System;

namespace _18_3_Galio
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int maxDiff = 0;
            bool shoulCalculateDiff = true;
            bool shouldCheckSum = true;

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int currentSum = a + b;
            int prevSum = currentSum;

            for (int i = 0; i < n - 1; i++)
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                currentSum = a + b;

                if (shouldCheckSum) 
                {
                    shoulCalculateDiff = prevSum == currentSum;
                }

                if (!shoulCalculateDiff)
                {
                    shouldCheckSum = false;

                    var currentdiff = Math.Abs(prevSum - currentSum);
                    prevSum = currentSum;

                    if (maxDiff < currentdiff)
                    {
                        maxDiff = currentdiff;
                    }
                }
            }

            if (maxDiff != 0)
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
            else
            {
                Console.WriteLine($"Yes, value={prevSum}");
            }
        }
    }
}

