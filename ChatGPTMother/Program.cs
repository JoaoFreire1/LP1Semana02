using System;

namespace ChatGPTMother
{
    public class Program
    {
        private static void Main(string[] args)
        {
            While (true)
            {
                string question;
                string response = "";

                Console.WriteLine("What is your question son?");
                question = Console.ReadLine();

                response = question switch
                {
                    "How are you?" => "I'm fine, thank you",
                    "What's your name?" => "You can call me Mom",
                    "What do you do in your spare time?" => "Kill puppies",
                    "Yes or no?" => "None",
                    _ => "Sorry I don't know the answer to that",

                    "EXIT" => null,
                
                };

                if (response = null)
                    {
                        break;
                    }

                Console.WriteLine(response);
            }
        }
    }
}
