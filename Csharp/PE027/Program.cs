using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int maxPrimes = 0;
            int coefA = 0;
            int coefB = 0;

            for (int b = 1000; b >= -1000; b--)
            {
                for (int a = 999; a >= -999; a--)
                {
                    int n = 0;
                    int foundPrimes = 0;
                    while (isPrime(n * n + n * a + b))
                    {
                        n++;
                        foundPrimes++;
                    }
                    if (maxPrimes < foundPrimes)
                    {
                        maxPrimes = foundPrimes;
                        coefA = a;
                        coefB = b;
                    }
                }
            }

            Console.WriteLine("{0}x{1} = {2}", coefA, coefB, coefA * coefB);
        }



        public static bool isPrime(long number)
        {
            if (number <= 1) return false;

            int divisors = 0;
            double sqroot = Math.Sqrt(number);
            for (int i = 2; i <= sqroot; i++)
            {
                if (number % i == 0)
                {
                    divisors++;
                }
            }

            return (divisors == 0);
        }
    }
}
