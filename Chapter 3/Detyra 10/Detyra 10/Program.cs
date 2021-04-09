using System;

namespace Detyra_10
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Enter a four-digit number: ");
			int number = int.Parse(Console.ReadLine());

			int num0 = number % 10;
			int num1 = (number / 10) % 10;
			int num2 = (number / 100) % 10;
			int num3 = (number / 1000) % 10;

			string strNumber0 = num0.ToString();
			string strNumber1 = num1.ToString();
			string strNumber2 = num2.ToString();
			string strNumber3 = num3.ToString();

			int sumOfDigits = num0 + num1 + num2 + num3;
			string reversedDigits = strNumber0 + strNumber1 + strNumber2 + strNumber3;
			string lastInFirstPosition = strNumber0 + strNumber2 + strNumber1 + strNumber3;
			string secondSwapThird = strNumber3 + strNumber1 + strNumber2 + strNumber0;

			Console.WriteLine($"Sum of digits of {number} is {sumOfDigits}.");
			Console.WriteLine($"Reversed number is {reversedDigits}");
			Console.WriteLine($"Last digit put in first position {lastInFirstPosition}");
			Console.WriteLine($"Second and third number swapped {secondSwapThird}");
		}
    }
}
