using System;

//not 4194302
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int limit = 4000000;
            int sum = 0;
            int lastTerm = 0;
            int currentTerm = 1;
            int nextTerm = 0;
            while (currentTerm < limit)
            {
                if (isEven(currentTerm))
                {
                    sum += currentTerm;
                }

                
                nextTerm = lastTerm + currentTerm;
                lastTerm = currentTerm;
                currentTerm = nextTerm;
            }

            Console.WriteLine(sum);
        }

        private static bool isEven(int number)
        {
            return (number % 2 == 0);
        }
    }
}
