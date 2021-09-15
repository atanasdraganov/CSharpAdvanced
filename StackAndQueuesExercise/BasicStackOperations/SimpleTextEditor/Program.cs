using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrOfOperations = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < nrOfOperations; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "1")
                {
                    stack.Push(sb.ToString());
                    sb.Append(command[1]);
                }
                else if(command[0] == "2")
                {
                    stack.Push(sb.ToString());
                    int countOfElements = int.Parse(command[1]);
                    sb.Remove(sb.Length-countOfElements, countOfElements);
                }
                else if(command[0] == "3")
                {
                    Console.WriteLine(sb[int.Parse(command[1])-1]);
                } 
                else if(command[0] == "4")
                {
                    if(sb.Length == 0)
                    {
                        sb.Append(stack.Pop());
                    }
                    else
                    {
                        sb.Replace(sb.ToString(), stack.Pop());
                    }
                }
            }
        }
    }
}
