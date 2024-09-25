using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallCalculator
{
    internal class program3
    {
        float userInput;
        float multiplyAmount;
        float divideAmount;

        Multiply();

        public void Multiply()
        {
            Console.Clear();
            Console.WriteLine("What number would you like to multiply?");
            userInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Now how much would you like to multiply that number?");
            multiplyAmount = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here's your answer!")
            Console.WriteLine(userInput *= multiplyAmount);
        }

        public void Divide()
        {
            Console.Clear();
            Console.WriteLine("What number would you like to divide?");
            userInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Now how much would you like to divide that number?");
            divideAmount = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here's your answer!")
            Console.WriteLine(userInput *= divideAmount);
        }
    }
}
