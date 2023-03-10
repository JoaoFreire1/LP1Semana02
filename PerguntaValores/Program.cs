using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the height of a cylinder");
            string a = Console.ReadLine();
            double aa = double.Parse(a );
            Console.WriteLine("Write the radius of a cylinder");
            string r = Console.ReadLine();
            double rr = double.Parse(r );
            Console.WriteLine(" V = " + (Math.PI)*(Math.Pow(rr, 2))*(aa));
            Console.WriteLine(" S = " + ( 2 * Math.PI * rr ) * ( rr + aa ));
        }
    }
}
