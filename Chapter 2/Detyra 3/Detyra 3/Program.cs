using System;

namespace Detyra_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            const double PRECISION = 0.000001;

            Console.Write("Enter the first number: ");
            double.TryParse(Console.ReadLine(), out n1);
            Console.Write("Enter the second number: ");
            double.TryParse(Console.ReadLine(), out n2);

            bool equal = Math.Abs(n1 - n2) < PRECISION;

            Console.WriteLine("The numbers are " + (equal ? "equal." : "different."));
        }
    }
}
