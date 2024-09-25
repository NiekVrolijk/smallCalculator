//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace smallCalculator
//{
//    internal class program3
//    {
//        float userInput;
//        float multiplyAmount;
//        float divideAmount;

//        Multiply();

//        public void Multiply()
//        {
//            double userInput;
//            double multiplyAmount;

//            Console.Clear();
//            Console.WriteLine("What number would you like to multiply?");

//            if (!double.TryParse(Console.ReadLine(), out userInput))
//            {
//                Console.WriteLine("\nERROR; try again");
//                Thread.Sleep(1000);
//                Multiply();
//                return;
//            }

//            Console.Clear();
//            Console.WriteLine("Now how much would you like to multiply that number?");

//            if (!double.TryParse(Console.ReadLine(), out multiplyAmount))
//            {
//                Console.WriteLine("\nERROR; try again");
//                Thread.Sleep(1000);
//                Multiply();
//                return;
//            }

//            Console.Clear();
//            Console.WriteLine("Here's your answer!");
//            Console.WriteLine(userInput * multiplyAmount);
//        }

//        public void Divide()
//        {
//            Console.Clear();
//            Console.WriteLine("What number would you like to divide?");

//            double userInput;
//            if (!double.TryParse(Console.ReadLine(), out userInput))
//            {
//                Console.WriteLine("\nERROR; try again");
//                Thread.Sleep(1000);
//                Divide();
//                return;
//            }

//            Console.Clear();
//            Console.WriteLine("Now how much would you like to divide that number?");

//            double divideAmount;
//            if (!double.TryParse(Console.ReadLine(), out divideAmount))
//            {
//                Console.WriteLine("\nERROR; try again");
//                Thread.Sleep(1000);
//                Divide();
//                return;
//            }

//            Console.Clear();
//            Console.WriteLine("Here's your answer!");
//            Console.WriteLine(userInput / divideAmount);
//        }
//    }
//}
