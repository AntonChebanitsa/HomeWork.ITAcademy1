using System;
using System.Runtime.ExceptionServices;

namespace HomeWork.ITAcademy1
{
    class Program
    {
        static void Main()
        {
            double first = 0;
            double second = 0;
            Console.WriteLine("Enter two numbers: ");
            try
            {
                Console.WriteLine($"First: {first = Convert.ToDouble(Console.ReadLine())}");
                Console.WriteLine($"Second: {second = Convert.ToDouble(Console.ReadLine())}\n\n" +
               $"List of operations: \n");
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not number!!\n");
                Main();
            }
            // todo add more operations
            Console.WriteLine("Summary is +\n" +
                "Subtraction is -\n" +
                "Mulplier is *\n" +
                "Division is: /");

            //todo make a loop to validate user input
            Console.Write($"Еnter the required operation: ");
            bool IsIncorrectFlag= false;
            do
            {
                string flag = Convert.ToString(Console.ReadLine());

                switch (flag)
                {
                    case "+":
                        Console.WriteLine($"The result of addition is: {Addition(first, second)}");
                        break;
                    case "*":
                        Console.WriteLine($"Your answer is: {Multiplier(first, second)}");
                        break;
                    case "-":
                        Subtraction(first, second);
                        break;
                    case "/":
                        Division(first, second);
                        break;
                    default:
                        Console.WriteLine("Invalid sign, try again");
                        break;
                }
            }
            while (IsIncorrectFlag == true);

            static double Addition(double first, double second)
            {
                return first + second;
            }
            static void Subtraction(double first, double second)
            {
                Console.WriteLine($"Your answer is: {first - second}");
            }
            static double Multiplier(double first, double second)
            {
                return first * second;
            }
            static void Division(double first, double second)
            {
                if (second == 0)
                {
                    Console.WriteLine("Division by zero. Enter numbers again");
                    Main();
                }
                else
                    Console.WriteLine($"Your answer is: {first / second}");
            }
        }
    }
}
