using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer:");
            int a = int.Parse(Console.ReadLine());

        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}