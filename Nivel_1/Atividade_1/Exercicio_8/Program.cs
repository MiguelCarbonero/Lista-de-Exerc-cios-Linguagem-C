using System;
using Exercicio_8.Model;

namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
             Varia aa = new Varia();

            Console.WriteLine("escreva a altura");
            aa.a = Console.ReadLine();

            aa.A = Double.Parse(aa.a);


            Console.WriteLine("\nescreva o raio");
            aa.a = Console.ReadLine();

            aa.R = Double.Parse(aa.a);

            aa.V = 3.14159 * aa.R * aa.R * aa.A;

            Console.WriteLine($"\nesse é o Volume {aa.V}");
        }
    }
}
