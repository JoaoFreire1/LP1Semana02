using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please ask me a question!");
                string question = Console.ReadLine();

                if (question == "How are you")
                {
                    Console.WriteLine("Terrible");
                    continue;
                }
                if (question == "What are you doing")
                {
                    Console.WriteLine("Nothing");
                    continue;
                }
                if (question == "Do you like cats")
                {
                    Console.WriteLine("Yes");
                    continue;
                }
                if (question == "Are you alive")
                {
                    Console.WriteLine("No");
                    continue;
                }
                if (question == "EXIT")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry I don't understand");
                    continue;
                }
            }

            
        }
    }
}
