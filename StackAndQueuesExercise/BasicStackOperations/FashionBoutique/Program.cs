using System;
using System.Linq;
using System.Collections.Generic;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothesValues = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int rackCapacity = int.Parse(Console.ReadLine());
            int currentCapacity = 0;
            int rackCount = 1;
            
            while(clothesValues.Count>0)
            {
                if(currentCapacity + clothesValues.Peek() > rackCapacity)
                {
                    currentCapacity = 0;
                    rackCount++;
                }
                currentCapacity += clothesValues.Pop();
            }
            Console.WriteLine(rackCount);
        }
    }
}
