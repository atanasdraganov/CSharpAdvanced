using System;
using System.Linq;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> queue = new Queue<string>();
            foreach (string song in songs)
            {
                queue.Enqueue(song);
            }
            
            while(queue.Count>0)
            {   
                string input = Console.ReadLine();
                if(input == "Play")
                {
                    queue.Dequeue();
                }
                
                else if(input == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }

                else
                {
                    int index = input.IndexOf(' ');
                    string song = input.Substring(index + 1);
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
