﻿using System;

namespace Detyra_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int number3;
            int number4;
            int number5;

            Console.WriteLine("Enter 5 integers: ");
            int.TryParse(Console.ReadLine(), out number1);
            int.TryParse(Console.ReadLine(), out number2);
            int.TryParse(Console.ReadLine(), out number3);
            int.TryParse(Console.ReadLine(), out number4);
            int.TryParse(Console.ReadLine(), out number5);

            int greatest = number1;

            if (greatest < number2)
            {
                greatest = number2;
            }

            if (greatest < number3)
            {
                greatest = number3;
            }

            if (greatest < number4)
            {
                greatest = number4;
            }

            if (greatest < number5)
            {
                greatest = number5;
            }

            Console.WriteLine("Greatest: {0}", greatest);

        }
    }
}
