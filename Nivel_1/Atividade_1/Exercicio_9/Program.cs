using System;
using Exercicio_9.Model_9;

namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Varia aa = new Varia();



            Console.WriteLine("Insira a sua idade: ");
            aa.a = Console.ReadLine();



            aa.Idad = int.Parse(aa.a);



            aa.Result = aa.Idad * 365;



            aa.Result_2 = aa.Idad * 12;



            aa.Result_3 = aa.Idad * 30;



            Console.WriteLine($"\nSua idade em anos = {aa.Result}");



            Console.WriteLine($"\nSua idade em mes = {aa.Result_2}");



            Console.WriteLine($"\nSua idade em dias = {aa.Result_3}");
        }
    }
}
