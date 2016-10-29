using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long numbers = 100;
            long sumOfSquares = SumOfSquares(numbers);
            long squareOfSum = SquareOfSum(numbers);
            long difference = squareOfSum - sumOfSquares;
            
            Console.WriteLine("sumOfSquares = {0}, squareOfSum = {1}",sumOfSquares, squareOfSum);
            Console.WriteLine(difference);
        }

        private static long SumOfSquares(long numbers){
            long sum = 0;
            for(long i=1;i<=numbers;i++){
                sum += i * i;
            }
            return sum;
        }

        private static long SquareOfSum(long numbers){
            long square = 0;
            for(long i=1;i<=numbers;i++){
                square += i;
            }
            return square * square;
        }
    }
}
