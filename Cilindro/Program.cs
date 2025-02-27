using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Diga a altura do cilindro");
            string ainput = Console.ReadLine();
            double a = double.Parse(ainput);
            Console.WriteLine("Diga o raio do cilindro");
            string rinput = Console.ReadLine();
            double r = double.Parse(rinput);
            double V = Math.PI * Math.Pow(r, 2) * a;
            double Sa = 2 * Math.PI * r * (r + a);
            string V1 = $"{V:f3}";
            Console.WriteLine(V1);
            string Sa1 = $"{Sa:f3}";
            Console.WriteLine(Sa1);

        }
    }
}
