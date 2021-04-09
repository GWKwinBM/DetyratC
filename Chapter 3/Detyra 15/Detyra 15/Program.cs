using System;

namespace Detyra_15
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

            
            uint bit3 = (number15 >> 3) & 1;
            uint bit24 = (number15 >> 24) & 1;
            number15 = (uint)(number15 & (~(1 << 24)) | (bit3 << 24));
            number15 = (uint)(number15 & (~(1 << 3)) | (bit24 << 3));

            uint bit4 = (number15 >> 4) & 1;
            uint bit25 = (number15 >> 25) & 1;
            number15 = (uint)(number15 & (~(1 << 25)) | (bit4 << 25));
            number15 = (uint)(number15 & (~(1 << 4)) | (bit25 << 4));

            uint bit5 = (number15 >> 5) & 1;
            uint bit26 = (number15 >> 26) & 1;
            number15 = (uint)(number15 & (~(1 << 26)) | (bit5 << 26));
            number15 = (uint)(number15 & (~(1 << 5)) | (bit26 << 5));

            Console.WriteLine("New number (Exercise 15): " + number15);

            
        }
    }
}
