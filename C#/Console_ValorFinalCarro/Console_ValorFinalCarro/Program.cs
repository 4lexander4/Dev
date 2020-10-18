using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_ValorFinalCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Objetivo: Calcular o valor final de um carro, tendo como entrada o custo de um carro.
             * O percentual do distribuidor é 28%
             * Impostos totais de 45%
             * Custo de fábrica 27%
             * 
             * Criação: 18/10/2020
             */

            float valorTotal, custoImpostos, custoFabrica, percentualDistribuidor;

            try
            {
                Console.WriteLine("-------------------------\n      Bem-vindo(a)!      \n-------------------------");
                Console.WriteLine("Informe o valor total do automóvel");
                valorTotal = float.Parse(Console.ReadLine());

                custoImpostos = (valorTotal * 0.45f);
                percentualDistribuidor = valorTotal * 0.28f;
                custoFabrica = valorTotal * 0.27f;

                Console.Clear();

                Console.WriteLine("-------------------------\n      Bem-vindo(a)!      \n-------------------------");
                Console.WriteLine("\nImpostos.....................: R$" + custoImpostos);
                Console.WriteLine("Percentual do distribuidor...: R$" + percentualDistribuidor);
                Console.WriteLine("Custo de fábrica.............: R$" + custoFabrica);
                Console.WriteLine("Valor total..................: R$" + valorTotal);

                Console.WriteLine("\nPressione qualquer tecla para encerrar...");
                Console.ReadKey();
            }
            catch (FormatException) 
            {
                Console.WriteLine("Informe um valor numérico");
            }
        }
    }
}
