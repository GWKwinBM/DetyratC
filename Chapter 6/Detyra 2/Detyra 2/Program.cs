using System;

namespace Detyra_2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Numbers in range 1 to N, not divisible both by 3 and 7 simultaneously");

			Console.Write("Enter N: ");
			long n = long.Parse(Console.ReadLine());

			for (long index = 1, counter = 0; index <= n; index++, counter++)
			{
				if (counter % 10 == 0 && index % 21 != 0)
				{
					Console.WriteLine();
				}

				if ((index % 21) == 0)
				{
					counter--;
					continue;
				}
				Console.Write("\t" + index);
			}

			Console.WriteLine();
		}
    }
}
