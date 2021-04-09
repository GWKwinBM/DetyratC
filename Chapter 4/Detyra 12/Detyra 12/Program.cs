using System;

namespace Detyra_12
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum = 0;
            float sumTest = 1;
            float fraction = 2F;

            while (Math.Abs(sumTest - sum) > 0.001)
            {
                sum = sumTest;
                if (fraction % 2 == 0)
                {
                    sumTest = sum + (1 / fraction);
                }
                else
                {
                    sumTest = sum - (1 / fraction);
                }
                fraction++;
            }

            Console.WriteLine("Result: {0}", sum);
        }
    }
}
