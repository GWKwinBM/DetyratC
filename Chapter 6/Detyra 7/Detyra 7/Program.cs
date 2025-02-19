﻿using System;

namespace Detyra_7
{
    class Program
    {
        static void Main(string[] args)
		{
			Console.WriteLine("Compute (N! * K!) / (N - K)! (where 1 < K < N)");

			Console.Write("Enter n: ");
			long n = long.Parse(Console.ReadLine());
			Console.Write("Enter k: ");
			long k = long.Parse(Console.ReadLine());

			double kFactorial = 1;
			double nFactorial = 1;
			double nMinusKFactorial = 1;
			for (int index = 1; index <= n; index++)
			{
				nFactorial *= index;

				if (index == k)
				{
					kFactorial = nFactorial;
				}
				if (index == (n - k))
				{
					nMinusKFactorial = nFactorial;
				}
			}

			Console.WriteLine($"{n}! = {nFactorial}, {k}! = {kFactorial}.");

			double result = (nFactorial * kFactorial) / nMinusKFactorial;

			Console.WriteLine($"({n}! * {k}!) / ({n} - {k})! is: {result}.");
		}
    }
}
