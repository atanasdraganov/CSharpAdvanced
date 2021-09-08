using System;
using System.Linq;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();
            string input = Console.ReadLine();
            while(input != "End")
            {   

                if(input == "Paid")
                {
                    foreach (var customer in customers)
                    {
                        Console.WriteLine(customer);
                    }
                    customers.Clear();
                    input = Console.ReadLine();
                    continue;
                }
                
                customers.Enqueue(input);
                input = Console.ReadLine();
            }
            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
