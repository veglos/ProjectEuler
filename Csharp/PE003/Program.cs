using System;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long number = 600851475143;
            //long number = 6008;
            long largestPrimeFactor = 1;

            for(long i=number-1;i>1;i--){
                if(number % i == 0 && isPrime(i)){
                    largestPrimeFactor = i;
                    break;
                }
            }

            Console.WriteLine("Largest prime factor is " + largestPrimeFactor);
        }

        public static bool isPrime(long number){
            Console.WriteLine("Divisor "+number+" found!");
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
