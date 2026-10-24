using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Class4
    {
        public static void Run()
        {

            double[,] A = { { 1, 2 }, { 3, 4 } };
            double[,] B = { { 5, 6 }, { 7, 8 } };

            Console.WriteLine("A:");
            PrintMatrix(A);
            Console.WriteLine("B:");
            PrintMatrix(B);

            Console.WriteLine("A*2:");
            PrintMatrix(MultiplyByScalar(A, 2));

            Console.WriteLine("A + B:");
            PrintMatrix(AddMatrices(A, B));

            Console.WriteLine("A * B:");
            PrintMatrix(MultiplyMatrices(A, B));
        }

        public static double[,] MultiplyByScalar(double[,] matrix, double scalar)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = matrix[i, j] * scalar;

            return result;
        }

        public static double[,] AddMatrices(double[,] A, double[,] B)
        {
            int rows = A.GetLength(0);
            int cols = A.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = A[i, j] + B[i, j];

            return result;
        }

        public static double[,] MultiplyMatrices(double[,] A, double[,] B)
        {
            int rowsA = A.GetLength(0);
            int colsA = A.GetLength(1);
            int colsB = B.GetLength(1);
            double[,] result = new double[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    for (int k = 0; k < colsA; k++)
                    {
                        result[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            return result;
        }

        private static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],5} ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
