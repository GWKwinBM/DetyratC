using System;

namespace Detyra_2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal inputNum = decimal.Parse(Console.ReadLine());

            decimal newNum = inputNum * 10000000;
            if (newNum % (long)newNum == 0)
            {
                Console.WriteLine("decimal; double; float");
            }
            else
            {
                newNum = inputNum * 1000000000000000;
                if (newNum % (long)newNum == 0)
                {
                    Console.WriteLine("decimal; double");
                }
                else
                {
                    Console.WriteLine("decimal");
                }

            }
        }
    }
}
