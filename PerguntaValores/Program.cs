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
            double Pi = 3.1415926;
            Console.WriteLine(" V = " + (Pi)*((rr)*(rr))*(aa));
            Console.WriteLine(" S = " + ( 2 * Pi * rr ) * ( rr + aa ));
        }
    }
}
