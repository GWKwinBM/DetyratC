using System;

namespace Detyra_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int five = 5;
            int ten = 10;
            int swapSum = five + ten;

            Console.WriteLine($"The original values are: five = {five}  ten = {ten}");
            Console.WriteLine($"The swapped values are: five = {swapSum - five}  ten = {swapSum - ten}");
        }
    }
}
