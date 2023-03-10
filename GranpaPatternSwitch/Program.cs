using System;

namespace GranpaPatternSwitch
{
   public class Program
    {
        private static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question, response;

            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            // Verificar se se trata de uma questão conhecida e determinar uma
            // resposta adequada

            string question = option switch
            {
                1 => "How are you?",
                2 => "What's your name?",
                3 => "What's your mission?",
                _ =>,
            }

            string question;
            switch (option)
            {
                case 1:
                    response = "I'm fine, thank you";
                    break;

                case 2:
                    response = "Gran'pa";
                    break;

                case 3:
                    response = "Destroy mankind!";
                    break;

                default :
                    response = "You got me, I'm not THAT smart!";
                    break;
            }

            // Responder adequadamente
            Console.WriteLine(response);
        }
    }
}
