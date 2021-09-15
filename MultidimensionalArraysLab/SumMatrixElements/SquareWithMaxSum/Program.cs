using System;
using System.Linq;
using System.Collections.Generic;

namespace SquareWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            int biggestSum = 0;
            int[,] biggestSquare = new int[2,2]{ { 0, 0 }, { 0, 0} };
            for (int row = 0; row < sizes[0]; row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    int newSquareSum = matrix[i, j] + matrix[i+1, j] + matrix[i, j+1] + matrix[i + 1, j + 1];
                    if(newSquareSum>biggestSum)
                    {
                        biggestSum = newSquareSum;
                        biggestSquare = new int[2, 2] { { matrix[i, j], matrix[i, j+1]}, { matrix[i+1, j], matrix[i + 1, j + 1]} };
                    }
                }
            }
            for (int i = 0; i < biggestSquare.GetLength(0); i++)
            {
                for (int j = 0; j < biggestSquare.GetLength(1); j++)
                {
                    Console.Write("{0} ", biggestSquare[i, j]);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine(biggestSum);
        }
    }
}
