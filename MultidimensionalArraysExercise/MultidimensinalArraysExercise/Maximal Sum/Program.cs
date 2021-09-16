using System;
using System.Linq;
using System.Collections.Generic;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] numbers = new int[size[0], size[1]];
            int[,] biggestMatrix = new int[3, 3];
            int sum = 0;
            for (int i = 0; i < size[0]; i++)
            {
                int[] rows = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < size[1]; j++)
                {
                    numbers[i, j] = rows[j];
                }
            }
            for (int i = 0; i < size[0]-2; i++)
            {
                for (int j = 0; j < size[1]-2; j++)
                {
                    if(numbers[i, j] + numbers[i, j + 1] + numbers[i, j + 2] +
                          numbers[i + 1, j] + numbers[i + 1, j + 1] + numbers[i + 1, j + 2] +
                          numbers[i + 2, j] + numbers[i + 2, j + 1] + numbers[i + 2, j + 2]>sum)
                    {
                        sum = numbers[i, j] + numbers[i, j + 1] + numbers[i, j + 2] +
                          numbers[i + 1, j] + numbers[i + 1, j + 1] + numbers[i + 1, j + 2] +
                          numbers[i + 2, j] + numbers[i + 2, j + 1] + numbers[i + 2, j + 2];
                        
                        biggestMatrix = new int[3,3]{
                            { numbers[i, j], numbers[i, j + 1], numbers[i, j + 2] },
                            { numbers[i + 1, j], numbers[i + 1, j + 1], numbers[i + 1, j + 2]},
                            { numbers[i + 2, j],  numbers[i + 2, j + 1], numbers[i + 2, j + 2] } 
                        };
                    }
                }
            }
            Console.WriteLine($"Sum = {sum}");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", biggestMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
