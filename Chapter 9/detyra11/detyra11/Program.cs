using System;

namespace detyra11
{
    class Program
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Reverse()
        {
            int numberReverse;
            string stringNumberReverse;
            do
            {
                Console.Clear();
                Console.Write("Enter a non-negative number: ");
                stringNumberReverse = Console.ReadLine();
                numberReverse = int.Parse(stringNumberReverse);
            } while (numberReverse < 0);

            Console.WriteLine("The number is inverted " + ReverseString(stringNumberReverse));
            Console.ReadLine();
        }

        static void Average()
        {
            int numberAverage = 0;
            int entries = -1;
            int temp;
            string numberAverageString;
            bool input;
            Console.Clear();

            do
            {
                Console.Write("Enter a number from the row. Enter a letter to complete:");
                numberAverageString = Console.ReadLine();
                input = Int32.TryParse(numberAverageString, out temp);
                numberAverage += temp;
                entries++;
            } while (input);

            Console.WriteLine("The arithmetic mean is {0}.", (float)numberAverage / entries);
            Console.ReadLine();
        }

        static void SolveEquation()
        {
            int a = 0;

            do
            {
                Console.Clear();
                Console.Write(" enter a: ");
                a = int.Parse(Console.ReadLine());
            } while (a == 0);

            Console.Write("enter b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("x = {0}", (float)-b / a);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            byte choice;

            do
            {
                Console.Clear();
                Console.WriteLine("##########################################");
                Console.WriteLine("#   M     M  EEEEEEE  N     N  U     U   #");
                Console.WriteLine("#   M M M M  E        N N   N  U     U   #");
                Console.WriteLine("#   M  M  M  EEEEE    N  N  N  U     U   #");
                Console.WriteLine("#   M     M  E        N   N N  U     U   #");
                Console.WriteLine("#   N     N  EEEEEEE  N     N   UUUUU    #");
                Console.WriteLine("##########################################" + System.Environment.NewLine);
                Console.WriteLine("1.Reverse the sequence of a number.");
                Console.WriteLine("2.Arithmetic mean of a number of numbers.");
                Console.WriteLine("3.Solving equation: a * c + b = 0.");
                Console.WriteLine("4.Exit.");
                Console.Write("Enter a selection: ");

                choice = byte.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: Reverse(); break;
                    case 2: Average(); break;
                    case 3: SolveEquation(); break;
                }

            } while (choice != 4);

            Console.WriteLine(System.Environment.NewLine + "Krai!");
            Console.ReadLine();
        }
    }
}
