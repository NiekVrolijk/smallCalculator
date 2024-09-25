using System.Diagnostics.CodeAnalysis;

namespace smallCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerOption;

            Console.WriteLine("Welkom to our small calculater!");
            AskPlayerOption();

            void AskPlayerOption()
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. adding");
                Console.WriteLine("2. subtrackting");
                Console.WriteLine("3. multiply");
                Console.WriteLine("4. divide");
                playerOption = ReadIntInput();
                switch (playerOption)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                }
            }

            int ReadIntInput()
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int result))
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("ERROR; try again");
                    }
                }
            }

            //else
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("ERROR; try again");
            //    [void here]();
            //}
        }
    }
}
