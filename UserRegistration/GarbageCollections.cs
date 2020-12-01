using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    class GarbageCollections
    {
         public static void garbage()
        {
            Console.WriteLine("Welcome to Garbage Colletion");
            long mem1 = GC.GetTotalMemory(false);
            {
                int[] values = new int[50000];
                values = null;
            }
            long mem2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }
            long mem3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(mem1);
                Console.WriteLine(mem2);
                Console.WriteLine(mem3);
            }
        }
    }
}
