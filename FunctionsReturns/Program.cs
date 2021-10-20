using System;

namespace FunctionsReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 25;

            int result = AddTwoNumbers();

            Console.WriteLine($"{a} + {b} ={result}");
        }
    }
}
