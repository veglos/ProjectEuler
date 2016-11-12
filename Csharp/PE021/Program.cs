using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int maxNumber = 10000;
            int[] amicables = GetAmicableNumbers(maxNumber);
            PrintArray(amicables);
            int sum = AddNumbers(amicables);
            Console.WriteLine(sum);
        }

        private static int[] GetAmicableNumbers(int maxnumber)
        {
            List<int> amicables = new List<int>();
            for (int i = 1; i < maxnumber; i++)
            {
                int di = d(i);
                int ddi = d(di);
                if (i == ddi && di != ddi)
                {
                    amicables.Add(di);
                }
            }
            return amicables.ToArray();
        }

        private static int AddNumbers(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        private static int d(int number)
        {
            int[] divisors = GetDivisors(number);
            int sum = 0;
            foreach (int d in divisors)
            {
                sum += d;
            }
            return sum;
        }

        private static int[] GetDivisors(int number)
        {
            if (number == 1) return new int[1] { 1 };
            List<int> divisors = new List<int>();
            for (int i = 1; i <= number / 2; i++)
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
