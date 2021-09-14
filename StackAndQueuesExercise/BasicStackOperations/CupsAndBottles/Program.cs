using System;
using System.Linq;
using System.Collections.Generic;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> cups = new Queue<int>();
            foreach (int cup in cupsArray)
            {
                cups.Enqueue(cup);
            }
            
            int[] bottelsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bottles = new Stack<int>();
            foreach (int bottle in bottelsArray)
            {
                bottles.Push(bottle);
            }
            
            int wastedLittersOfWater = 0;

            while (bottles.Count != 0 && cups.Count != 0)
            {
                if (bottles.Peek() >= cups.Peek())
                {
                    int remainingLiters = bottles.Peek() - cups.Peek();
                    wastedLittersOfWater += remainingLiters;
                    cups.Dequeue();
                    bottles.Pop();
                }
                else
                {
                    int firstCup = cups.Peek();
                    while(firstCup>0)
                    {
                        firstCup -= bottles.Peek();
                        bottles.Pop();
                        if(firstCup<=0)
                        {
                            cups.Dequeue();
                            wastedLittersOfWater += Math.Abs(firstCup);
                        }
                        if (!bottles.Any())
                        {
                            break;
                        }
                    }
                }
            }

            if (bottles.Count > cups.Count)
            { 
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedLittersOfWater}");
        }
    }
}
