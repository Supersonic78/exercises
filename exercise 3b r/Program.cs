using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3b_r
{
    class Program
    {
        static void Main(string[] args)
        {

            bool a = true;

            while (a)
            {
                Console.Clear();
                Menu();
                string messageNumberOne = "Input number one sucker!";
                string messageNumberTwo = "And again bitch!";

                switch (Console.ReadLine().ToUpper())
                {
                    case "A":
                        Console.Clear();
                        Console.WriteLine("Add");
                        double inputNumber1 = ReadNumber(messageNumberOne);
                        double inputNumber2 = ReadNumber(messageNumberTwo);
                        double sumAdd = inputNumber1 + inputNumber2;
                        Console.WriteLine("Sum = " + sumAdd);
                        a = AnotherCalc();
                        break;

                    case "B":
                        Console.Clear();
                        Console.WriteLine("Subtract");
                        InputNumbers(out inputNumber1, out inputNumber2);
                        double sumSub = inputNumber1 - inputNumber2;
                        Console.WriteLine("Sum = " + sumSub);
                        a = AnotherCalc();
                        break;

                    case "C":
                        Console.Clear();
                        Console.WriteLine("Multiply");
                        InputNumbers(out inputNumber1, out inputNumber2);
                        double sumMply = inputNumber1 * inputNumber2;
                        Console.WriteLine("Sum = " + sumMply);
                        a = AnotherCalc();
                        break;

                    case "D":
                        Console.Clear();
                        Console.WriteLine("Divide");
                        InputNumbers(out inputNumber1, out inputNumber2);
                        double sumDiv = inputNumber1 / inputNumber2;
                        Console.WriteLine("Sum = " + sumDiv);
                        a = AnotherCalc();
                        break;



                    default:
                        Console.WriteLine("INPUT ERROR!");
                        break;


                }
            }

        }

        private static bool AnotherCalc()
        {
            Console.WriteLine("Do you want to make another calculation? (y/n)");
            return Console.ReadLine() == "y";
        }

        private static void InputNumbers(out double inputNumber1, out double inputNumber2)
        {
            Console.WriteLine("Input the first number");
            inputNumber1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number");
            inputNumber2 = double.Parse(Console.ReadLine());
        }

        // double d1 = ReadNumber("Input the first number");
        // double d2 = ReadNumber("Input the second number");
        private static double ReadNumber(string message)
        {
            Console.WriteLine(message);
            return double.Parse(Console.ReadLine());
        }

        private static void Menu()
        {
            Console.WriteLine("Select an operator");
            Console.WriteLine("------------------");
            Console.WriteLine("A.Addition(+)");
            Console.WriteLine("B.Subtraction(-)");
            Console.WriteLine("C.Multiplication(*)");
            Console.WriteLine("D.Division(/)");
        }

    }
}
