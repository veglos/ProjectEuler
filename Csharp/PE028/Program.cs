using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int dimension = 1001;
            int number = dimension * dimension;
            int difference = dimension - 1;
            int sum = 0;

            while (number > 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum += number;                    
                    number -= difference;
                }
                difference -= 2;
            }
            sum++;

            Console.WriteLine(sum);
        }
    }
}
