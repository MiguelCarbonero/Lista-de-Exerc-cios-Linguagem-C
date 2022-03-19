using System;
using Exercicio_5.Model_5;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Varia aa = new Varia();

            Console.WriteLine("Escreva a velocidade");
            aa.a = Console.ReadLine();

            aa.velo = Double.Parse(aa.a);


            Console.WriteLine("escreva o tempo da viagem");
            aa.a = Console.ReadLine();

            aa.tem = Double.Parse(aa.a);

            aa.dist = aa.velo * aa.tem;

            aa.gaso = aa.dist / 12;

            Console.WriteLine($"\nEssa é a velocidade {aa.velo} ");


            Console.WriteLine($"Essa é o Tempo da viagem {aa.tem} ");


            Console.WriteLine($"Essa é a distancia {aa.dist} ");


            Console.WriteLine($"Essa é o total de galolina gasta {aa.gaso} ");
        }
    }
}
