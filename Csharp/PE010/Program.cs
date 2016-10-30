using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long limit = 2000000;
            long sum = 0;
            for(long i=2;i<limit;i++){
                if(isPrime(i)){
                    sum += i;
                }
            }

            Console.WriteLine("Find the sum of all the primes below {0} is {1}",limit,sum);
        }

        public static bool isPrime(long number){
            if(number <= 1) return false;

            int divisors = 0;
            double sqroot = Math.Sqrt(number);
            for(int i=2; i<=sqroot;i++){
                if(number % i == 0){
                    divisors++;
                }
            }
            
            return (divisors == 0);
        }
    }
}
