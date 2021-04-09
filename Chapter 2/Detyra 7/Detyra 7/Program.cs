using System;

namespace Detyra_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Hello");
            string word1 = Console.ReadLine();
            Console.WriteLine("Type World");
            string word2 = Console.ReadLine();
            object word1PlusWord2 = word1 + " " + word2;
            Console.WriteLine(word1PlusWord2);

        }
    }
}
