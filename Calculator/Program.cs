using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Multiplication();
        }

        static void Multiplication()
        {
            Console.Write("variable 1 =");
            int variable1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("variable 2 =");
            int variable2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("var1 * var2 = " + (variable1 * variable2));
            Console.ReadLine();
        }
    }
}
