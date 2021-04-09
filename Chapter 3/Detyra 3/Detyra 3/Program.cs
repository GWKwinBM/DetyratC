using System;

namespace Detyra_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            char charInHunderedsPlace = userInput[userInput.Length - 3];
            bool contains7 = string.Equals(charInHunderedsPlace, '7');

            if (contains7)
                Console.WriteLine($"{userInput} contains 7 in hundered's place.");
            else
                Console.WriteLine($"{userInput} does not contain 7 in hundered's place.");
        }
    }
}
