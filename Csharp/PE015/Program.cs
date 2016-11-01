using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double sideLength = 20;
            double totalMovements = sideLength * 2;
            double halfMovements = sideLength;

            double totalCombinations = GetFactorial(totalMovements) / (GetFactorial(halfMovements) * GetFactorial(halfMovements));

            Console.WriteLine(totalCombinations);
        }

        public static double GetFactorial(double number)
        {
            double result = 1;
            for (double i = number; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
