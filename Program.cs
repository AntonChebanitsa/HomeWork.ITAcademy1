using System;
using System.Runtime.ExceptionServices;

namespace HomeWork.ITAcademy1
{
    class Program
    {

        static void Main()
        {
            Initialisations();
        }

        static void Initialisations()
        {
            Console.WriteLine("Press any key to continue. If you want exit press ESC");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Random random1 = new Random();
                Random random2 = new Random();
                double firstNumber = Math.Round(random1.NextDouble() * 50, 3);
                double secondNumber = Math.Round(random2.NextDouble() * 10, 3);

                //Console.WriteLine("Enter numbers: ");
                //try
                //{
                //    Console.Write("First: ");
                //    first = Convert.ToDouble(Console.ReadLine());
                //}
                //catch (FormatException)
                //{
                //    Console.WriteLine("This is not number!!\n");
                //    Initialisations()();
                //}
                Console.WriteLine("Summary is \t\t+\n" +
                    "Subtraction is \t\t-\n" +
                    "Mulplier is \t\t*\n" +
                    "Division is \t\t/\n" +
                    "Factorial is \t\t!\n" +
                    "Exponentiation is \te");
                Console.Write($"Еnter the required operation: ");
                string operation = Convert.ToString(Console.ReadLine());
                if (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "e" && operation != "!")
                {
                    Console.WriteLine("Incorrect input!\nTry again from begin\n");
                    Initialisations();
                }
                if (operation != "!")
                {
                    //try
                    //{
                    //    Console.Write($"Second: ");
                    //    second = Convert.ToDouble(Console.ReadLine());
                    //}
                    //catch (FormatException)
                    //{
                    //    Console.WriteLine("This is not number!!\n");
                    //    Initialisations()();
                    //}
                    InsertionOperation(firstNumber, secondNumber, operation);
                }
                else
                    Console.WriteLine($"Factorial {firstNumber} is {Factorial(firstNumber)}");
            }
        }

        static void InsertionOperation(double first, double second, string operation)
        {
            bool IsIncorrectFlag = false;
            do
            {
                IsIncorrectFlag = false;
                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"The result of addition {first} and {second} is: {Addition(first, second)}\n");
                        break;
                    case "*":
                        Console.WriteLine($"The result of multiply {first} and {second} is:{Multiplier(first, second)}\n");
                        break;
                    case "-":
                        Console.WriteLine($"The result of subtraction {first} and {second} is:{Subtraction(first, second)}");
                        break;
                    case "/":
                        Console.WriteLine($"The result of division {first} and {second} is:{Division(first, second)}");
                        break;
                    case "e":
                        Console.WriteLine($"The result of exponentiation {first}  and {second} is:{Exponentiation(first, second)}\n");
                        break;
                    default:
                        IsIncorrectFlag = true;
                        break;
                }
            }
            while (IsIncorrectFlag == true);
        }

        static double Addition(double first, double second)
        {
            return first + second;
        }
        static double Subtraction(double first, double second)
        {
            return first - second;
        }
        static double Multiplier(double first, double second)
        {
            return first * second;
        }
        static double Division(double first, double second)
        {
            if (second == 0)
            {
                Console.WriteLine("Division by zero. Enter numbers again");
                Initialisations();
            }
            return first / second;
        }
        static double Factorial(double first)
        {
            Console.WriteLine("The number will be cast to an integer type");
            first = (int)first;
            double result = 1;
            for (int i = (int)first; i > 0; i--)
                result = i * result;
            return result;
        }
        static double Exponentiation(double first, double second)
        {
            Console.WriteLine("The growth rate will be cast to an integer type");
            if (second % 1 != 0)
                if (second % 1 > 0.5)
                    second = (int)second + 1;
                else second = (int)second;
            for (int i = 0; i < second; i++)
                first *= first;
            return first;
        }
    }
}