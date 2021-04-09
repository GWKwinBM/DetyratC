using System;

namespace Detyra_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you a male?\nAnswer only with True and False.");
            bool isMale = bool.Parse(Console.ReadLine());
            if (isMale == true)
            {
                Console.WriteLine("You are male");
            }
            else
            {
                Console.WriteLine("You are female");
            }

        }
    }
}
