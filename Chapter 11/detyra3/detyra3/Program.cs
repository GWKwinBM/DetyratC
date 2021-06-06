using System;

namespace detyra3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = Int32.Parse(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = Int32.Parse(Console.ReadLine());
            Console.Write("Enter day: ");
            int day = Int32.Parse(Console.ReadLine());

            DateTime dateValue = new DateTime(year, month, day);
            Console.WriteLine(dateValue.ToString("ddd"));
        }
    }
}
