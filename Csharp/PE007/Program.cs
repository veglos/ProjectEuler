using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long nthPlace = 10001;
            long place = 0;
            long number = 0;

            while(place != nthPlace){
                number++;
                if(isPrime(number)){
                    place++;
                }
            }

            Console.WriteLine(number);
        }

        public static bool isPrime(long number){
            if(number == 1) return false;

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
