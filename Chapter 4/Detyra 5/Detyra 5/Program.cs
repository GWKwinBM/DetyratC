using System;

namespace Detyra_5
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Numbers in Range (a, b) divisible by 5");

			Console.Write("Enter lower bound of the range: ");
			int lowerBound = int.Parse(Console.ReadLine());

			Console.Write("Enter upper bound of the range: ");
			int upperBound = int.Parse(Console.ReadLine());

			string divisibleBy5 = "";
			int index = lowerBound;
			int counter = 0;

		
			while (true)
			{
				if (index % 5 == 0)
					break;
				index++;
			}

			while (index <= upperBound)
			{
				counter++;
				divisibleBy5 = divisibleBy5 + " " + index;
				index += 5;
			}

			Console.WriteLine($"There are {counter} numbers divisible by 5 in range ({lowerBound}, {upperBound}).");
			Console.WriteLine($"The numbers are {divisibleBy5}.");
		}
    }
}
