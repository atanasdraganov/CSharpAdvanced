using System;
using System.Linq;
using System.Collections.Generic;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> integers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).Reverse());
            
            while(!integers.All(i => i%2==0))
            {
                if(integers.Peek()%2==0)
                {
                    integers.Enqueue(integers.Dequeue());
                }
                else
                {
                    integers.Dequeue();
                }
            }
            Console.WriteLine(string.Join(", ", integers.Reverse()));
        }
    }
}
