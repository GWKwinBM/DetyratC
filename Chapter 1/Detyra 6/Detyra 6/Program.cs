using System;

namespace Detyra_6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Older = 10;
            byte actualAge = 0;

            Console.Write("Enter your actual age: ");
            byte.TryParse(Console.ReadLine(), out actualAge);

            actualAge += Older;

            Console.WriteLine("Your age in {0} years will be {1}.", Older, actualAge);

        }
    }
}
