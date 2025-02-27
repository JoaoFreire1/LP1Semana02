using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Por favor escreve um numero inteiro");
            string nstring = Console.ReadLine();
            sbyte n = sbyte.Parse(nstring);
            n = n--;
            Console.WriteLine(n);
            n = n++;
            Console.WriteLine(n);

        }
    }
}
