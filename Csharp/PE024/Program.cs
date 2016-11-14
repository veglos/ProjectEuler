using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long[] digits = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            long rank = 1000000;

            long permutation = GetPermutation(rank, digits);

            Console.WriteLine(permutation);

        }

        private static long GetLowest(long[] digits)
        {
            String number = string.Empty;
            foreach (long d in digits)
            {
                number = number + d.ToString();
            }
            return long.Parse(number);
        }

        private static long GetHighest(long[] digits)
        {
            String number = string.Empty;
            for (long i = digits.Length - 1; i >= 0; i--)
            {
                number = number + digits[i].ToString();
            }

            return long.Parse(number);
        }

        private static long GetPermutation(long rank, long[] digits)
        {
            long lowest = GetLowest(digits);
            long highest = GetHighest(digits);

            long currentRank = 0;
            for (long i = lowest; i <= highest; i++)
            {
                if (CanBeFormed(i, digits))
                {
                    currentRank++;
                    if (currentRank == rank)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }

        private static bool CanBeFormed(long number, long[] digits)
        {
            string numberDigits = number.ToString();
            if (numberDigits.Length < digits.Length)
            {
                numberDigits = "0" + numberDigits;
            }

            foreach (char c in numberDigits)
            {
                long digit = long.Parse(c.ToString());
                if (IsInArray(digit, digits))
                {
                    long previousLength = digits.Length;
                    digits = RemoveFromArray(digit, digits);
                    long newLength = digits.Length;
                    if (previousLength == newLength) return false;
                }
                else
                {
                    return false;
                }
            }
            return true;

        }

        private static long[] RemoveFromArray(long number, long[] array)
        {
            List<long> result = new List<long>();
            foreach (long a in array)
            {
                if (a == number) continue;
                result.Add(a);
            }
            return result.ToArray();
        }

        private static bool IsInArray(long number, long[] array)
        {
            foreach (long a in array)
            {
                if (number == a) return true;
            }
            return false;
        }
    }
}
