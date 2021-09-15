using System;
using System.Linq;
using System.Collections.Generic;

namespace BalancedParantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] parantheses = input.ToCharArray();
            Queue<char> paranthesesQueue = new Queue<char>();

            foreach (char bracket in parantheses)
            {
                paranthesesQueue.Enqueue(bracket);
            }
            Stack<char> paranthesesStack = new Stack<char>();

            foreach (char bracket in parantheses)
            {
                paranthesesStack.Push(bracket);
            }
            bool isEqual = false;

            while (paranthesesQueue.Count > 0)
            {
                char parantheses1 = paranthesesQueue.Dequeue();
                char parantheses2 = paranthesesStack.Pop();
                if(parantheses.Length%2!=0)
                {
                    isEqual = false;
                }
                else if (parantheses1 == '(' && parantheses2 == ')')
                {
                    isEqual = true;
                }
                else if(parantheses1 == '[' && parantheses2 == ']')
                {
                    isEqual = true;
                }
                else if (parantheses1 == '{' && parantheses2 == '}')
                {
                    isEqual = true;
                }
                else if (parantheses1 == ')' || parantheses1 == ']' || parantheses1 == '}')
                {
                    break;
                }
                else
                {
                    isEqual = false;
                    break;
                }
            }
            if (isEqual)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
