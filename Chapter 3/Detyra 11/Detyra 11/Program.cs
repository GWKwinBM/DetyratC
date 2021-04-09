using System;

namespace Detyra_11
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Program to print binary digit at pth position in number n");
			Console.WriteLine("position starts form 0");
			Console.WriteLine();
			Console.Write("Enter a number: ");
			int number = int.Parse(Console.ReadLine());

			Console.Write("Enter the position for which to get the binary digit: ");
			int position = int.Parse(Console.ReadLine());

			number >>= (position);

			if ((number & 1) == 1)
			{
				Console.WriteLine($"Bit on position {position} is 1.\n");
			}
			else
			{
				Console.WriteLine($"Bit on position {position} is 0.\n");
			}
		}
    }
}
