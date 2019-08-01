using System;

namespace BitMap
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            var bm = new BitMap();
            bm.Add(1);
            bm.Add(2);
            bm.Add(4);
            bm.Add(255);
 
            Console.WriteLine(bm.ToString());
            
            Console.WriteLine(bm.Contains(1));
            Console.WriteLine(bm.Contains(2));
            Console.WriteLine(bm.Contains(3));

            Console.WriteLine(bm.Contains(255));
            Console.WriteLine(bm.Contains(256));
            
            
            Console.ReadKey();
        }
    }
}
