using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second integer:");
            int b = int.Parse(Console.ReadLine());

            int sum = Sum(a, b); // Функция вызывается здесь
            Console.WriteLine($"Sum of {a} and {b} is {sum}.");
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}