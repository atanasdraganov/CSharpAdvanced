using System;
using System.Linq;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(Console.ReadLine().Split().Reverse());
            while(stack.Count>1)
            {
                int first = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int second = int.Parse(stack.Pop());
                stack.Push(operation == "+" ? (first + second).ToString() : (first - second).ToString());
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
