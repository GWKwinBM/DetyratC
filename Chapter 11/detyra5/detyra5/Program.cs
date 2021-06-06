using System;

namespace detyra5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First side: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Second side: ");
            int b = Int32.Parse(Console.ReadLine());

            Console.Write("Hypotenuse is: " + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
        }
    }
}
