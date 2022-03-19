using System;
using Exercicio_6.Model;


namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Varia aa = new Varia();

            Console.WriteLine("escreva o grau em Celsius");
            aa.a = Console.ReadLine();

            aa.C = Math.Round(Double.Parse(aa.a), 2);

            aa.F = (9 * aa.C + 160);
            aa.F = Math.Round(aa.F / 5 ,2);

            Console.WriteLine($"Fahrenheit = {aa.F}");
                
        }
    }
}
