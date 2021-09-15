using System;
using System.Linq;
using System.Collections.Generic;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            for (int i = 0; i < sizes[0]; i++)
            {
                int[] col = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < sizes[1]; j++)
                {
                    matrix[i, j] = col[j];
                }
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
