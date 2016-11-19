using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int longest = 0;
            int d = 0;
            for (int i = 2; i < 1000; i++)
            {
                int[] numerators = GetNumerators(i);
                int[] cycle = GetCycle(i, numerators.Length);
                if (longest < cycle.Length)
                {
                    longest = numerators.Length;
                    d = i;                 
                }                
            }

            Console.Write("d = {0}", d);               
        }

        private static int[] GetNumerators(int denominator)
        {
            List<int> numerators = new List<int>();
            int numerator = 1;
            while (true)
            {
                while (numerator < denominator) numerator *= 10;
                if (IsInList(numerator, numerators)) break;
                numerators.Add(numerator);
                numerator = numerator % denominator;
                if (numerator == 0) break;
            }
            return numerators.ToArray();
        }

        public static int[] GetCycle(int denominator, int numerators)
        {
            List<int> cycle = new List<int>();

            int numerator = 1;
            int division = 1;

            while (cycle.Count < numerators)
            {
                while (numerator < denominator) numerator *= 10;
                division = numerator / denominator;
                numerator = numerator % denominator;
                //if (IsInList(division, cycle)) break;
                cycle.Add(division);
                if (numerator == 0)
                {
                    //remove non cylic divisions
                    cycle.Clear();
                    break;
                }
            }

            return cycle.ToArray();
        }

        public static int[] GetCycle2(int denominator)
        {
            List<int> cycle = new List<int>();

            int numerator = 1;
            int division = 1;

            while (cycle.Count < 30)
            {
                while (numerator < denominator) numerator *= 10;
                division = numerator / denominator;
                numerator = numerator % denominator;
                //if (IsInList(division, cycle)) break;
                cycle.Add(division);
                if (numerator == 0) break;
            }

            return cycle.ToArray();
        }

        private static bool IsInList(int number, List<int> list)
        {
            foreach (int a in list)
            {
                if (number == a) return true;
            }
            return false;
        }

        private static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
