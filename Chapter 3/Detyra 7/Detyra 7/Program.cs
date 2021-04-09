using System;

namespace Detyra_7
{
    class Program
    {
        static void Main(string[] args)
		{
			Console.WriteLine("\tCalculate your weight on moon\n");

			Console.Write("\tEnter your weight on Earth: ");
			float weightOnEarth = float.Parse(Console.ReadLine());
			float weightOnMoon = weightOnEarth * ((float)17 / 100);

			Console.WriteLine($"\tYour weight on Moon is {weightOnMoon}");
		}
    }
}
