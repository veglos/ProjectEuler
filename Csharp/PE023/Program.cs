using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    //WARNING: SLOW
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nonAbundantSums = GetAllNonAbundantSums(28123);
            int sum = SumNumbers(nonAbundantSums);
            Console.WriteLine(sum);
        }

        private static int[] GetAllNonAbundantSums(int limit)
        {
            List<int> nonAbundantSums = new List<int>();
            for (int i = 1; i < limit; i++)
            {
                if (!IsSumOfTwoAbundant(i)) nonAbundantSums.Add(i);
            }
            return nonAbundantSums.ToArray();
        }

        private static bool IsSumOfTwoAbundant(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int j = number - i;
                if (j <= 0) continue;
                if (IsAbundant(i) && IsAbundant(j)) return true;
            }
            return false;
        }

        private static bool IsAbundant(int number)
        {
            int[] divisors = GetProperDivisors(number);
            int sum = SumNumbers(divisors);
            return (sum > number);
        }

        private static int SumNumbers(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        private static int[] GetProperDivisors(int number)
        {
            if (number == 1) return new int[1] { 1 };
            List<int> divisors = new List<int>();
            for (int i = 1; i < (number / 2) + 1; i++)
            {
                if (number % i == 0) divisors.Add(i);
            }
            return divisors.ToArray();
        }

        private static void PrintArray(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
