
using System;
using System.Linq;
using System.Collections.Generic;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int sumPrimary = 0;
            int sumSecondary = 0;
            for (int row = 0; row < size; row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = colElements[col];
                    if (row == col)
                    {
                        sumPrimary += matrix[row, col];
                    }
                    if(row+col == size-1)
                    {
                        sumSecondary += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(Math.Abs(sumPrimary-sumSecondary));
        }
    }
}