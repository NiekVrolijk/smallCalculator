using System;

namespace smallCalculator
{
    internal class Program2
    {

        float userInput;
        float addAmount;
        float subtractAmount;

        public void Add()
        {
            Console.Clear();
            Console.WriteLine("What number would you like to start with?");
            userInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Now how much would you like to add to " + userInput + "?");
            addAmount = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here's your answer!")
            Console.WriteLine(userInput += multiplyAmount);
        }

        public void Subtract()
        {
            Console.Clear();
            Console.WriteLine("What number would you like to start with?");
            userInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Now how much would you like to subtract from " + userInput + "?");
            subtractAmount = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here's your answer!")
            Console.WriteLine(userInput -= multiplyAmount);
        }
    }
}
