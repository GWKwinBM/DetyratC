using System;

namespace detyra1
{
    class Program
    {
        static void ReturnName(string name)
        {
            Console.WriteLine("Hello qikats {0}", name);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            ReturnName(Console.ReadLine());
        }
    }
}