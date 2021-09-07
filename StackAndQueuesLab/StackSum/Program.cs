using System;
using System.Linq;
using System.Collections.Generic;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            var commandInfo = Console.ReadLine().ToLower();
            while(commandInfo!="end")
            {
                var tokens = commandInfo.Split();
                var command = tokens[0].ToLower();
                if(command == "add")
                {
                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));
                }
                else if(command == "remove")
                {
                    var countOfRemovedNumbers = int.Parse(tokens[1]);
                    if (stack.Count < countOfRemovedNumbers)
                        continue;
                    for(int i= 0;i<countOfRemovedNumbers;i++)
                    {
                        stack.Pop();
                    }
                }
                commandInfo = Console.ReadLine().ToLower();
            }
            var sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
