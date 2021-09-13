using System;
using System.Linq;
using System.Collections.Generic;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindowSeconds = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int totalCarsPassed = 0;

            while (true) 
            {
                string command = Console.ReadLine();
                int greenLight = greenLightSeconds;
                int freeWindow = freeWindowSeconds;

                if(command == "END")
                {
                    Console.WriteLine($"Everyone is safe.");
                    Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
                    return;
                }
                
                if(command == "green")
                {
                    while (greenLight>0 && cars.Count!=0)
                    {
                        string firstInQueue = cars.Dequeue();
                        greenLight -= firstInQueue.Length;
                        if (greenLight > 0)
                        {
                            totalCarsPassed++;
                        }
                        else
                        {
                            freeWindow += greenLight;
                            if (freeWindow < 0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{firstInQueue} was hit at {firstInQueue[firstInQueue.Length + freeWindow]}.");
                                return;
                            }
                            totalCarsPassed++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }

        }
    }
}
