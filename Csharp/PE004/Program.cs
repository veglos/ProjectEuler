using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long maxFactor = 999;
            long minFactor = 100;
            long product = 0;
            long number1 = 0;
            long number2 = 0;
            long largestPalindrome = 0;

            for(long i=maxFactor;i>=minFactor;i--){
                for(long j=maxFactor;j>=minFactor;j--){
                    product = i*j;
                    if(isPalindrome(product)){
                        
                        if(product > largestPalindrome) {
                            largestPalindrome = product;
                            number1 = i;
                            number2 = j;
                        }
                    }
                }
            }

            Console.WriteLine(number1 +" x "+number2+" = "+largestPalindrome);
        }

        private static bool isPalindrome(long number){
            String text = number.ToString();
            int j = text.Length - 1;
            for(int i=0;i<text.Length;i++){
                if(text[i] != text[j]){
                    return false;
                }
                j--;
            }
            return true;
        }
    }
}
