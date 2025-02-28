using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            While (true)
            {
                Console.WriteLine("Please ask me a question!");
                string question == Console.ReadLine();

                if (question == "How are you")
                    Console.WriteLine("Terrible");
                    break;
                if (question == "What are you doing")
                    Console.WriteLine("Nothing");
                    break;
                if (question == "Do you like cats")
                    Console.WriteLine("Yes");
                    break;
                if (question == "Are you alive")
                    Console.WriteLine("No");
                    break;
                if (question == "EXIT")
                    break;
            }

            
        }
    }
}
