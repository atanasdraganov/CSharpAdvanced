﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int count = 0;
            string command = Console.ReadLine();
            while(command!= "end")
            {
                if(command == "green")
                {
                    for(int i=0; i<N; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        count++;
                    }
                    command = Console.ReadLine();
                    continue;
                }
                cars.Enqueue(command);
                command = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
