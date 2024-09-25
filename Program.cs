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
                        Add();
                        break;
                    case 2:
                        Subtract();
                        break;
                    case 3:
                        Multiply();
                        break;
                    case 4:
                        Divide();
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                AskPlayerOption();
            }

            void Add()
            {
                Console.Clear();
                Console.WriteLine("What number would you like to start with?");

                double userInput;
                if (!double.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("\nERROR; try again");
                    Thread.Sleep(1000);
                    Add();
                    return;
                }

                Console.Clear();
                Console.WriteLine("Now how much would you like to add to " + userInput + "?");

                double addAmount;
                if (!double.TryParse(Console.ReadLine(), out addAmount))
                {
                    Console.WriteLine("\nERROR; try again");
                    Thread.Sleep(1000);
                    Add();
                    return;
                }

                Console.Clear();
                Console.WriteLine("Here's your answer!");
                Console.WriteLine(userInput + addAmount);
            }

            void Subtract()
            {
                Console.Clear();
                Console.WriteLine("What number would you like to start with?");

                double userInput;
                if (!double.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("\nERROR; try again");
                    Thread.Sleep(1000);
                    Subtract();
                    return;
                }

                Console.Clear();
                Console.WriteLine("Now how much would you like to subtract from " + userInput + "?");

                double subtractAmount;
                if (!double.TryParse(Console.ReadLine(), out subtractAmount))
                {
                    Console.WriteLine("\nERROR; try again");
                    Thread.Sleep(1000);
                    Subtract();
                    return;
                }

                Console.Clear();
                Console.WriteLine("Here's your answer!");
                Console.WriteLine(userInput - subtractAmount);
            }


            void Multiply()
            {
                double userInput;
                double multiplyAmount;

                Console.Clear();
                Console.WriteLine("What number would you like to multiply?");

                if (!double.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("\nERROR; try again");
                    Thread.Sleep(1000);
                    Multiply();
                    return;
                }

                Console.Clear();
                Console.WriteLine("Now how much would you like to multiply that number?");

                if (!double.TryParse(Console.ReadLine(), out multiplyAmount))
                {
                    Console.WriteLine("\nERROR; try again");
                    Thread.Sleep(1000);
                    Multiply();
                    return;
                }

                Console.Clear();
                Console.WriteLine("Here's your answer!");
                Console.WriteLine(userInput * multiplyAmount);
            }

            void Divide()
            {
                Console.Clear();
                Console.WriteLine("What number would you like to divide?");

                double userInput;
                if (!double.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("\nERROR; try again");
                    Thread.Sleep(1000);
                    Divide();
                    return;
                }

                Console.Clear();
                Console.WriteLine("Now how much would you like to divide that number?");

                double divideAmount;
                if (!double.TryParse(Console.ReadLine(), out divideAmount))
                {
                    Console.WriteLine("\nERROR; try again");
                    Thread.Sleep(1000);
                    Divide();
                    return;
                }

                Console.Clear();
                Console.WriteLine("Here's your answer!");
                Console.WriteLine(userInput / divideAmount);
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
        }
    }
}
