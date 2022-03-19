using System;
using Exercicio_4.Model_4;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Varia fff = new Varia();

            Console.WriteLine("Primeiro valor");
            fff.aaa = Console.ReadLine();

            fff.A = int.Parse(fff.aaa);



            Console.WriteLine("Segundo valor");
            fff.aaa = Console.ReadLine();

            fff.B = int.Parse(fff.aaa);



            Console.WriteLine("Terceiro valor");
            fff.aaa = Console.ReadLine();

            fff.C = int.Parse(fff.aaa);



            Console.WriteLine("Quarto valor");
            fff.aaa = Console.ReadLine();

            fff.D = int.Parse(fff.aaa);



            fff.BF = (fff.A + fff.B);
            Console.WriteLine($"\n { fff.A } { '+' } { fff.B } = { fff.BF } ");

            fff.CF = (fff.A + fff.C);
            Console.WriteLine($" { fff.A } { '+' } { fff.C } = { fff.CF } ");

            fff.DF = (fff.A + fff.D);
            Console.WriteLine($" { fff.A } { '+' } { fff.D } = { fff.DF } ");

            fff.EF = (fff.B + fff.C);
            Console.WriteLine($" { fff.B } { '+' } { fff.C } = { fff.EF } ");

            fff.FF = (fff.B + fff.D);
            Console.WriteLine($" { fff.B } { '+' } { fff.D } = { fff.FF } ");

            fff.GF = (fff.C + fff.D);
            Console.WriteLine($" { fff.C } { '+' } { fff.D } = { fff.GF } \n");

            Console.WriteLine("=====================================================");

            fff.BF = (fff.A * fff.B);
            Console.WriteLine($"\n { fff.A } { '*' } { fff.B } = { fff.BF } ");

            fff.CF = (fff.A * fff.C);
            Console.WriteLine($" { fff.A } { '*' } { fff.C } = { fff.CF } ");

            fff.DF = (fff.A * fff.D);
            Console.WriteLine($" { fff.A } { '*' } { fff.D } = { fff.DF } ");

            fff.EF = (fff.B * fff.C);
            Console.WriteLine($" { fff.B } { '*' } { fff.C } = { fff.EF } ");

            fff.FF = (fff.B * fff.D);
            Console.WriteLine($" { fff.B } { '*' } { fff.D } = { fff.FF } ");

            fff.GF = (fff.C * fff.D);
            Console.WriteLine($" { fff.C } { '*' } { fff.D } = { fff.GF } ");
        }
    }
}
