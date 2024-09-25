//using System;

//namespace smallCalculator
//{
//    internal class Program2
//    {
//        public void Add()
//        {
//            Console.Clear();
//            Console.WriteLine("What number would you like to start with?");

//            double userInput;
//            if (!double.TryParse(Console.ReadLine(), out userInput))
//            {
//                Console.WriteLine("\nERROR; try again");
//                Thread.Sleep(1000);
//                Add();
//                return;
//            }

//            Console.Clear();
//            Console.WriteLine("Now how much would you like to add to " + userInput + "?");

//            double addAmount;
//            if (!double.TryParse(Console.ReadLine(), out addAmount))
//            {
//                Console.WriteLine("\nERROR; try again");
//                Thread.Sleep(1000);
//                Add();
//                return;
//            }

//            Console.Clear();
//            Console.WriteLine("Here's your answer!");
//            Console.WriteLine(userInput + addAmount);
//        }

//        public void Subtract()
//        {
//            Console.Clear();
//            Console.WriteLine("What number would you like to start with?");

//            double userInput;
//            if (!double.TryParse(Console.ReadLine(), out userInput))
//            {
//                Console.WriteLine("\nERROR; try again");
//                Thread.Sleep(1000);
//                Subtract();
//                return;
//            }

//            Console.Clear();
//            Console.WriteLine("Now how much would you like to subtract from " + userInput + "?");

//            double subtractAmount;
//            if (!double.TryParse(Console.ReadLine(), out subtractAmount))
//            {
//                Console.WriteLine("\nERROR; try again");
//                Thread.Sleep(1000);
//                Subtract();
//                return;
//            }

//            Console.Clear();
//            Console.WriteLine("Here's your answer!");
//            Console.WriteLine(userInput - subtractAmount);
//        }

//    }
//}
//}
