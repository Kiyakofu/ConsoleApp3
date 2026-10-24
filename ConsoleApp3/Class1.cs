using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Class1
    {
        public static void Run()
        {
            double[] A = new double[5];
            double[,] B = new double[3, 4];
            Random rand = new Random();

            Console.WriteLine("5 num. a:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"A[{i}] = ");
                A[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = Math.Round(rand.NextDouble() * 100, 2);
                }
            }

            Console.WriteLine("\narr a:");
            Console.WriteLine(string.Join(" ", A));

            Console.WriteLine("\narr b:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write($"{B[i, j],7} ");
                }
                Console.WriteLine();
            }

            double max = A[0];
            double min = A[0];
            double totalSum = 0;
            double totalProduct = 1;
            double sumEvenA = 0;
            double sumOddColsB = 0;

            foreach (double num in A)
            {
                if (num > max) max = num;
                if (num < min) min = num;
                totalSum += num;
                totalProduct *= num;

                if (num % 2 == 0) sumEvenA += num;
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    double num = B[i, j];
                    if (num > max) max = num;
                    if (num < min) min = num;
                    totalSum += num;
                    totalProduct *= num;

                    if (j % 2 != 0) 
                    {
                        sumOddColsB += num;
                    }
                }
            }

            Console.WriteLine($"\nmax: {max}");
            Console.WriteLine($"min: {min}");
            Console.WriteLine($"totalSum: {totalSum}");
            Console.WriteLine($"totalProduct: {totalProduct}");
            Console.WriteLine($"sumEvenA: {sumEvenA}");
            Console.WriteLine($"sumOddColsB: {sumOddColsB}");
        }
    }
}
