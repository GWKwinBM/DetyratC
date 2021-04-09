using System;

namespace Detyra_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            Console.Write("Enter an integer: ");
            int.TryParse(Console.ReadLine(), out number);

            Console.WriteLine("The number " + (number % 35 == 0 ? "is" : "isn't") + " divisible by 5 and 7.");
        }
    }
}
