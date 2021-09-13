using System;
using System.Linq;
using System.Collections.Generic;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);
            int sum = 0;
            Console.WriteLine(orders.Max());
            while (queue.Count > 0)
            {
                int firstInLine = queue.Peek();
                sum += firstInLine;
                if (sum <= food)
                {
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    break;
                }
            }
            if(queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            
        }
    }
}
