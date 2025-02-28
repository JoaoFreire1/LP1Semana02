using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ask me Something!");
            string question = Console.ReadLine();

            while (true)
            {
                if (question == "What's your name")
                    Console.WriteLine("Ambrosio");
                    break;

                if (question == "How are you")
                    Console.WriteLine("Terrible");
                    break;

                if (question == "Do you like Shrek")
                    Console.WriteLine("Yes of course");
                    break;

                if (question == "Are you alive")
                    Console.WriteLine("No I'm dead inside");
                    break;
            }

            
        }
    }
}
