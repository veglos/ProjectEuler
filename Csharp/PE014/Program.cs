using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int limit = 1000000;
            int from = 13;


            int longestChain = 0;
            int startingNumber = from;
            for (int i = from; i < limit; i++)
            {
                int chain = Process(i, 0);
                if (chain > longestChain) {
                    longestChain = chain;
                    startingNumber = i;
                }
            }

            Console.WriteLine(startingNumber);
        }

        private static int Process(long number, int count)
        {
            if (number == 1)
            {
                return ++count;
            }
            else
            {
                if (number % 2 == 0)
                {
                    return Process(number / 2, ++count);
                }
                else
                {
                    return Process(3 * number + 1, ++count);
                }
            }
        }
    }
}
