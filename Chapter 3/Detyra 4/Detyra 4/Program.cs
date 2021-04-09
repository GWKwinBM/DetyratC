using System;

namespace Detyra_4
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Enter a number to check it's third bit(from right): ");
			int userInput = int.Parse(Console.ReadLine());
			int isItOne = (int)(userInput & 4);
			if (isItOne == 0)
				Console.WriteLine($"{userInput}'s third bit from right is 0.");
			else if (isItOne == 4)
				Console.WriteLine($"{userInput}'s third bit from right is 1.");
		}
    }
}
