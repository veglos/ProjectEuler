using System;

namespace ConsoleApplication
{
    public class Program
    {
        //WARNING: Very Slow
        public static void Main(string[] args)
        {
            int maxDivisors = 500;
            bool triangleFound = false;
            int position = 1;
            long triangle = 0;
            int divisors = 0;

            while (!triangleFound)
            {
                triangle = GetTriangle(position);
                divisors = GetDivisors(triangle);
                if (divisors > maxDivisors) triangleFound = true;
                position++;
            }

            Console.WriteLine(triangle);
        }

        private static long GetTriangle(int position)
        {
            long triangle = 0;
            for (int i = 1; i <= position; i++)
            {
                triangle += i;
            }
            return triangle;
        }

        private static int GetDivisors(long triangle)
        {
            int divisors = 0;
            for (long i = 1; i <= triangle; i++)
            {
                if (triangle % i == 0) divisors++;
            }
            return divisors;
        }
    }
}
