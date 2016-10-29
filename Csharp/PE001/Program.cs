using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int limit = 1000;
            int sum = 0;
            for (int i = 1; i < limit; i++)
            {
                if (isMultipleOfThree(i))
                {
                    sum += i;
                }
                else if (isMultipleOfFive(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }

        private static bool isMultipleOfThree(int number)
        {
            if (number % 3 == 0) return true;
            return false;
        }

        private static bool isMultipleOfFive(int number)
        {
            if (number % 5 == 0) return true;
            return false;
        }
    }
}
