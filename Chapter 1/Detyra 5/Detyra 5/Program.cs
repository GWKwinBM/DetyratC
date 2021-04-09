using System;

namespace Detyra_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to calculate it's square-root: ");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine($"Square-root of {number} is: {Math.Sqrt(number)}.");
        }
    }
}
