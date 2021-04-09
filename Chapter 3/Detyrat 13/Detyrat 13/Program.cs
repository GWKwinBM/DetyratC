using System;

namespace Detyrat_13
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Program to change bit at position \"p\" to bit \"v\" of number \"n\"");
			Console.WriteLine("Position starts form 0");
			Console.WriteLine();

			Console.Write("Enter the number: ");
			int number = int.Parse(Console.ReadLine());
			Console.Write("Enter the position to be changed: ");
			int position = int.Parse(Console.ReadLine());
			Console.Write($"Enter the new Value for position {position}: ");
			int newBitValue = int.Parse(Console.ReadLine());

			int tempNumber = number;
			tempNumber >>= position;
			int newNumber = 0;

			if ((tempNumber & 1) == 1)
			{
				if (newBitValue == 0)
					newNumber = number & (~(int)Math.Pow(2, position));
				else if (newBitValue == 1)
					newNumber = number | 0;
			}
			else
			{
				if (newBitValue == 1)
					newNumber = number | (int)Math.Pow(2, position);
				else if (newBitValue == 0)
					newNumber = number | 0;
			}
			Console.WriteLine($"The number {number} after converting position {position} bit to {newBitValue} is {newNumber}");
		}
    }
}
