using System;
using Exercicio_1.Model;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {

            
                Varia bbb = new Varia();



                Console.WriteLine("Digite o valor minino da peça");
                bbb.aaa = Console.ReadLine();

                bbb.quant_Min = int.Parse(bbb.aaa);



                Console.WriteLine("Digite o valor maximo da peça");
                bbb.aaa = Console.ReadLine();

                bbb.quant_Max = int.Parse(bbb.aaa);



                bbb.quant_Media = (bbb.quant_Min + bbb.quant_Max);
                bbb.quant_Media = (bbb.quant_Media / 2);
                Console.WriteLine($" {bbb.quant_Min} { '+' } {bbb.quant_Max} ({ '/' } { 2 }) = { bbb.quant_Media } ");
            }
    }
}
