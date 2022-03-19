using System;
using Exercicio_2.Model_2;


namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Varia ccc = new Varia();

            Console.WriteLine("Entre com o valor do dolar");
            ccc.aaa = Console.ReadLine();

            ccc.Num1 = double.Parse(ccc.aaa);

            Console.WriteLine("Entre com o quantidade desejaza em dolar");
            ccc.aaa = Console.ReadLine();

            ccc.Num2 = double.Parse(ccc.aaa);


            ccc.result = Math.Round(ccc.Num2 * ccc.Num1, 4);
            Console.WriteLine($"R$ { ccc.Num2 } { '*' } { ccc.Num1 } = { ccc.result } ");
        }
    }
}
