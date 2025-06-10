using System;
using System.Numerics;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number to calculate its factorial:");
            int num = Convert.ToInt32(Console.ReadLine());

            BigInteger result = CalculateFactorial(num);
            Console.WriteLine($"{num}! = {result}");

            Console.ReadLine();
        }

        static BigInteger CalculateFactorial(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
                return -1;
            }

            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
