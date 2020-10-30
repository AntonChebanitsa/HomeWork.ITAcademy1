using System;
using System.Runtime.ExceptionServices;

namespace HomeWork.ITAcademy1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Press any key to continue. If you want exit press ESC");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape) 
            {
                Initialisations();
            }
        }

        static void Initialisations()
        {

            double first = 0;
            double second = 0;
            string operation = null;
            Console.WriteLine("Enter numbers: ");
            try
            {
                Console.Write("First: ");
                first = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not number!!\n");
                Main();
            }
            Console.WriteLine("Summary is \t\t+\n" +
                "Subtraction is \t\t-\n" +
                "Mulplier is \t\t*\n" +
                "Division is \t\t/\n" +
                "Factorial is \t\t!\n" +
                "Exponentiation is \te");
            Console.Write($"Еnter the required operation: ");
            operation = Convert.ToString(Console.ReadLine());
            if (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "^" && operation != "!")
            {
                Console.WriteLine("Incorrect input!\nTry again from begin\n");
                Main();
            }
            if (operation != "!")
            {
                try
                {
                    Console.Write($"Second: ");
                    second = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not number!!\n");
                    Main();
                }
                InsertionFlag(first, second, operation);
            }
            else
                Console.WriteLine($"Factorial {first} is {Factorial(first)}");

        }

        static void InsertionFlag(double first, double second, string flag)
        {
            bool IsIncorrectFlag = false;
            do
            {
                IsIncorrectFlag = false;
                switch (flag)
                {
                    case "+":
                        Console.WriteLine($"The result of addition is: {Addition(first, second)}\n");
                        break;
                    case "*":
                        Console.WriteLine($"Your answer is: {Multiplier(first, second)}\n");
                        break;
                    case "-":
                        Console.WriteLine($"{first} subtract {second} is {Subtraction(first, second)}");
                        break;
                    case "/":
                        Console.WriteLine($"The result of division: {Division(first, second)}");
                        break;
                    case "e":
                        Console.WriteLine($"Number {first} in extent {second} is:{Exponentiation(first, second)}\n");
                        break;
                    default:
                        Console.WriteLine("Invalid sign, try again");
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
                Main();
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