using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApplication
{
    // Also solves problem 67
    public class Program
    {
        private static string filename = "triangle.txt";

        public static void Main(string[] args)
        {
            int[][] triangle = GetTriangle(filename);
            int[] finalLine = GetLargestLine(triangle);
            int largestNumber = GetLargestNumber(finalLine);
            Console.WriteLine("The largest sum is {0}", largestNumber);
        }

        private static int GetLargestNumber(int[] line)
        {
            int largestNumber = 0;
            foreach (int number in line)
            {
                largestNumber = (number > largestNumber) ? number : largestNumber;
            }
            return largestNumber;
        }

        private static int[] GetLargestLine(int[][] triangle)
        {

            List<int> finalLine = InitializeFinalLine(triangle);

            for (int i = 0; i < triangle.GetLength(0) - 1; i++)
            {
                //left arm
                finalLine[0] = triangle[i + 1][0] + triangle[i][0];
                //right arm
                finalLine[i + 1] = triangle[i + 1][i + 1] + triangle[i][i];


                for (int j = 1; j < triangle[i + 1].GetLength(0) - 1; j++)
                {
                    int leftCandidate = triangle[i + 1][j] + triangle[i][j - 1];
                    int rightCandidate = triangle[i + 1][j] + triangle[i][j];
                    finalLine[j] = (leftCandidate > rightCandidate) ? leftCandidate : rightCandidate;
                }

                triangle[i + 1] = finalLine.ToArray();

                foreach (int number in triangle[i + 1])
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }

            return finalLine.ToArray();
        }

        private static List<int> InitializeFinalLine(int[][] triangle)
        {
            List<int> finalLine = new List<int>(triangle[triangle.GetLength(0) - 1]);

            for (int i = 0; i < finalLine.Count; i++)
            {
                finalLine[i] = 0;
            }

            return finalLine;
        }

        private static int[][] GetTriangle(string filename)
        {
            FileStream fs = File.OpenRead(filename);
            System.IO.StreamReader file = new System.IO.StreamReader(fs);
            string line = string.Empty;

            List<int[]> triangle = new List<int[]>();
            while ((line = file.ReadLine()) != null)
            {
                string[] a = line.Split(' ');
                List<int> numbers = new List<int>();
                foreach (string s in a)
                {
                    numbers.Add(int.Parse(s));
                }
                triangle.Add(numbers.ToArray());
            }

            return triangle.ToArray();
        }
    }
}
