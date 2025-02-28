using System;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string start1 = Console.ReadLine();
            int start = int.Parse(start1);
            Console.WriteLine($"Start number: {start}");
            string step1 = Console.ReadLine();
            int step = int.Parse(step1);
            Console.WriteLine($"Step number: {step}");

            if (start < 1)
            {
                Console.WriteLine("Out-of-range start or step. Try again.")
            }

            if (step < 1)
            {
                Console.WriteLine("Out-of-range start or step. Try again.")
            }
        }
    }
}
