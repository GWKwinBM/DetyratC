using System;

namespace Detyra_4
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Print three numbers in a format");

			Console.Write("Enter number 1: ");
			int oneNumber = int.Parse(Console.ReadLine());
			Console.Write("Enter number 2: ");
			double twoNumber = double.Parse(Console.ReadLine());
			Console.Write("Enter number 3: ");
			double threeNumber = double.Parse(Console.ReadLine());

			Console.WriteLine();
			
			Console.Write($"0x{oneNumber,-10:X}");
			Console.Write($"{twoNumber,-10:F}");
			Console.Write($"{threeNumber,-10:F}");
			Console.WriteLine();
			Console.WriteLine();
		
	}
    }
}
