using System;
using System.Linq;
using System.Collections.Generic;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2nd exercise is the same but with a queue.
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = integers[0];
            int s = integers[1];
            int x = integers[2];
            
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(numbers[i]);
            }

            for(int i=0; i<s; i++)
            {
                stack.Pop();
            }

            if (stack.Any())
            {
                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else 
                {
                    Console.WriteLine(stack.Min());
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
