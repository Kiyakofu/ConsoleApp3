using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Class2
    {
        public static void Run()
        {
            int[,] matrix = new int[5, 5];
            Random rand = new Random();

            Console.WriteLine("5*5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rand.Next(-100, 101);
                    Console.Write($"{matrix[i, j],5} ");
                }
                Console.WriteLine();
            }

            int minIdx = 0, maxIdx = 0;
            int minVal = matrix[0, 0];
            int maxVal = matrix[0, 0];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int currentIdx = i * 5 + j;
                    int val = matrix[i, j];

                    if (val < minVal) { minVal = val; minIdx = currentIdx; }
                    if (val > maxVal) { maxVal = val; maxIdx = currentIdx; }
                }
            }

            Console.WriteLine($"\nminVal: {minVal} (minIdx {minIdx}), maxVal: {maxVal} (maxIdx {maxIdx})");

            int start = Math.Min(minIdx, maxIdx);
            int end = Math.Max(minIdx, maxIdx);
            int sum = 0;

            for (int k = start + 1; k < end; k++)
            {
                int row = k / 5;
                int col = k % 5;
                sum += matrix[row, col];
            }

            Console.WriteLine($"sum: {sum}");
        }
    }
}
