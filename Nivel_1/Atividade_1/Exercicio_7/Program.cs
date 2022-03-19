using System;
using Exercicio_7.Model;

namespace Exercicio_7
{
    class Program   
    {
        static void Main(string[] args)
        {
             Varia aa = new Varia();

            Console.WriteLine("escreva o grau em Fahrenheit");
            aa.a = Console.ReadLine();

            aa.F = Math.Round(Double.Parse(aa.a), 2);

            aa.C = Math.Round((aa.F - 32) * 5 / 9 ,2);


            Console.WriteLine($"Celsius = {aa.C}");
        }
    }
}
