using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            addition();
        }

        static void addition()
        {
            int firstNumber, secondNumber, result;

            Console.WriteLine("Enter your first number:");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            secondNumber = int.Parse(Console.ReadLine());

            result = firstNumber + secondNumber;
            Console.WriteLine("Our Addition Result: " + result);
        }
    }
}
