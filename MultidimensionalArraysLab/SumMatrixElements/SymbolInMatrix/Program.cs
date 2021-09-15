using System;
using System.Linq;
using System.Collections.Generic;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                if(size == 1 && size!=0)
                {
                    matrix[0, 0] = char.Parse(Console.ReadLine());
                }
                else
                {
                    char[] colElements = Console.ReadLine().ToCharArray();
                    for (int col = 0; col < size; col++)
                    {
                        matrix[row, col] = colElements[col];
                    }
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            bool isFound = false;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        isFound = true;
                        Console.WriteLine($"({row}, {col})");
                        break;
                    }
                }
                if(isFound)
                {
                    break;
                }
            }
            if(isFound == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
