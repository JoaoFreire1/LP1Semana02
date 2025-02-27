using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere número inteiro-não negativo:");
            string ninput = Console.ReadLine();
            byte n = byte.Parse(ninput);
            Console.ReadLine(n);

        }
    }
}
