using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int x = int.Parse( args );
            foreach (string arg in args)
            {
                Console.WriteLine(x++);
                Console.WriteLine(--x);
            }
           
        }
    }
}
