using System;
using System.Runtime.ExceptionServices;

namespace HomeWork.ITAcademy1
{
    class Program
    {
        static void Main()
        {
            double first;
            double second;
            Console.WriteLine("Enter two numbers: ");
            Console.WriteLine($"First: {first = Convert.ToDouble(Console.ReadLine())}");
            Console.WriteLine($"Second: {second = Convert.ToDouble(Console.ReadLine())}\n\n" +
                $"List of operations: \n");

            Console.WriteLine("Summary is +\n" +
                "Subtraction is -\n" +
                "Mulplier is *\n" +
                "Division is: /");

            Console.Write("Еnter the required operation: ");
            string op = Convert.ToString(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine($"Your answer is: {Addition(first, second)}");
                    break;
                case "*" :
                    Console.WriteLine($"Your Answer is: {Multiplier(first,second)}");
                    break;
                case "-":
                    Console.WriteLine($"Your Answer is: {Subtraction(first,second)}");
                    break;
                case "/":
                    Console.WriteLine($"Your Answer is: {Division(first,second)}");
                    break;
                default:
                    break;
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
                try
                {
                    return first / second;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Divide by zero error!!!");
                    throw;
                }
            }

        }

    }
}
