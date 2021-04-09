using System;

namespace Detyra_16
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number15;
            uint number16;

            Console.Write("Enter a number (32 bit unsigned int): ");
            uint.TryParse(Console.ReadLine(), out number15);
            number16 = number15;
           

            uint bitI;
            uint bitIPlus15;

            for (int i = 1; i <= 16; i++)
            {
                bitI = (number16 >> i) & 1;
                bitIPlus15 = (number16 >> (i + 16)) & 1;
                number16 = (uint)(number16 & (~(1 << (i + 16))) | (bitI << (i + 16)));
                number16 = (uint)(number16 & (~(1 << i)) | (bitIPlus15 << i));
            }

            Console.WriteLine("New number (Exercise 16): " + number16);
        }
    }
}
