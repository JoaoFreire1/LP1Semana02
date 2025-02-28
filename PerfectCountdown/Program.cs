using System;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                string start1 = Console.ReadLine();
                int start = int.Parse(start1);
                Console.WriteLine($"Start number: {start}");
                string step1 = Console.ReadLine();
                int step = int.Parse(step1);
                Console.WriteLine($"Step number: {step}");

                if (start < 1)
                {
                    Console.WriteLine("Out-of-range start or step. Try again.");
                }

                else if (step < 1)
                {
                    Console.WriteLine("Out-of-range start or step. Try again.");
                    continue;
                }

                else if (step >= start)
                {
                    Console.WriteLine("Start number must be hgher than step. Try again.");
                    continue;
                }
                
                else if (start % step == 0)
                {
                    Console.WriteLine("YAY");
                    continue;
                }

                else
                {
                    Console.WriteLine("Start not divisible by step. Try again.");
                    continue;
                }
            }
        }
    }
}
