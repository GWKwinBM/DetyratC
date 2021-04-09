using System;

namespace Detyra_1
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Calculate the Sum");

			Console.Write("Enter first number: ");
			float firstNumber = float.Parse(Console.ReadLine());

			Console.Write("Enter second number: ");
			float secondNumber = float.Parse(Console.ReadLine());

			Console.Write("Enter third number: ");
			float thirdNumber = float.Parse(Console.ReadLine());

			float sumOf3 = firstNumber + secondNumber + thirdNumber;
			Console.WriteLine($"Sum of {firstNumber} + {secondNumber} + {thirdNumber} is {sumOf3}.");
			Console.WriteLine($"Or Simply {firstNumber} + {secondNumber} + {thirdNumber} = {sumOf3}");
		}
    }
}
