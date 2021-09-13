using System;
using System.Linq;
using System.Collections.Generic;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int intelligence = int.Parse(Console.ReadLine());
            int locksCounter = 0;
            int usedBullets = 0;

            while(bullets.Count>0 && locks.Count > 0)
            {
                if(bullets.Peek()<=locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    bullets.Pop();
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();
                }
                locksCounter++;

                if(locksCounter == barrelSize && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    locksCounter = 0;
                }
                usedBullets++;
            }

            if(bullets.Count>=0 && locks.Count == 0)
            {
                int moneyEarned = intelligence - usedBullets * bulletPrice;
                if (moneyEarned < 0)
                {
                    Console.WriteLine($"{bullets.Count} bullets left. Earned $0");
                }
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }

            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
