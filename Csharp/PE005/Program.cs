using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long smallestNumber = 20;
            long divisors = 0;
            while(divisors != 20){
                
                for(long i=1;i<=20;i++){
                    if(smallestNumber % i == 0){
                        divisors++;
                    }
                }

                if(divisors != 20){
                    divisors = 0;
                    smallestNumber++;
                }
            }

            Console.WriteLine("Smallest positive number is {0}", smallestNumber);
        }
    }
}
