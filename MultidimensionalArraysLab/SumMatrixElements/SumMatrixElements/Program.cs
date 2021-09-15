using System;
using System.Linq;
using System.Collections.Generic;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            int sum = 0;
            for(int row = 0; row<sizes[0]; row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = colElements[col];
                    sum += matrix[row, col];
                }
            }
            Console.WriteLine(sizes[0]);
            Console.WriteLine(sizes[1]);
            Console.WriteLine(sum);
        }
    }
}
