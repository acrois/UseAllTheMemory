using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UseAllTheMemory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerformanceCounter counter = new PerformanceCounter("Memory", "Available MBytes", null);
            LinkedList<int> memstore = new LinkedList<int>();

            while (true)
            {
                memstore.AddLast(1337);

                if (memstore.Count % 1000000 == 0)
                {
                    Console.WriteLine(counter.NextValue());
                }
            }
        }
    }
}
