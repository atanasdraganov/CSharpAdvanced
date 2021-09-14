using System;
using System.Linq;
using System.Collections.Generic;

namespace MinAndMaxElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < queries; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                switch(command[0])
                {
                    case 1:
                        stack.Push(command[1]);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                }
            }
            if(stack.Any())
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
