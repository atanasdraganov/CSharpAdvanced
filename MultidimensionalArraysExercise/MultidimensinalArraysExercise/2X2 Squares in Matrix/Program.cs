using System;
using System.Linq;
using System.Collections.Generic;

namespace _2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] characters = new string[size[0], size[1]];
            int counter = 0;
            for (int i = 0; i < size[0]; i++)
            {
                string[] rows = Console.ReadLine().Split();
                for (int j = 0; j < size[1]; j++)
                {
                    characters[i, j] = rows[j];
                }
            }
            for (int i = 0; i < size[0]-1; i++)
            {
                for (int j = 0; j < size[1]-1; j++)
                {
                    if(characters[i, j] == characters[i, j+1] && characters[i, j+1] == characters[i+1, j] && characters[i+1, j] == characters[i+1, j+1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
 