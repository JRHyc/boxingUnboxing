using System;
using System.Collections.Generic;

namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<object> empty = new List<object>();
            empty.Add(7);
            empty.Add(28);
            empty.Add(-1);
            empty.Add(true);
            empty.Add("chair");
            int sum = new int();
            foreach (var entry in empty)
            {
                if (entry is int)
                {
                    sum += (int)entry;
                }
                Console.WriteLine(entry);    
            }            
            Console.WriteLine(sum);







        }
    }
}
