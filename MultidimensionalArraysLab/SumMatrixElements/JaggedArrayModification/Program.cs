using System;
using System.Linq;
using System.Collections.Generic;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowSize = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rowSize][];
            for (int r = 0; r < rowSize; r++)
            {
                int[] col = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[r] = col;
            }
            string line = Console.ReadLine();
            while (line!="END")
            {
                string[] tokens = line.Split();
                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);
                if(row<0 || row>=matrix.Length || col<0 || col>=matrix[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if(command == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    else if(command == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }
                line = Console.ReadLine();
            }
            foreach (int[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
