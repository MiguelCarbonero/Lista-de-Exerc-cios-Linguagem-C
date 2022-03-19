using System;
using Exercicio_3.Model_3;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Varia_2 ddd = new Varia_2();
            Varia eee = new Varia();

            ddd.cpf = "78179979";
            ddd.telef = "19 9999999";
            ddd.nome = "sam";

            Console.WriteLine("escreva o codigo da peça");
            eee.codigo = Console.ReadLine();

            Console.WriteLine("escreva o preço da peça");
            eee.preco = Console.ReadLine();

            Console.WriteLine("quantidade vendida");
            eee.quant = Console.ReadLine();

            Console.WriteLine("================================");

            Console.WriteLine(ddd.nome);
            Console.WriteLine(ddd.telef);
            Console.WriteLine(ddd.cpf);

            Console.WriteLine("================================");

            Console.WriteLine(eee.codigo);
            Console.WriteLine(eee.quant);
            Console.WriteLine(eee.preco);
        }
    }
}
