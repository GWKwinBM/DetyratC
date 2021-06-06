using System;

namespace Detyra_10
{
    class Program
    {
        private const int V = 3;

        static void Main(string[] args)
        {
            Console.WriteLine("The Matrix pattern");
            for (int row = 0; row < 3; row++)
                for (int column = row; column + V; column++)
                {
                    Console.WriteLine($"{column + 1,3}");
                }
            Console.WriteLine();


        }
    }
}
