
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentualEleicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Objetivo: Informar a % de cada tipo de voto (em branco, nulo e válido), com base nos dados solciitados ao usuário
             * Criação: 18/10/2020
             */

            try
            {
                float totalEleitores, votosEmBranco, votosNulos, votosValidos;

                Console.WriteLine("-------------------------\n      Bem-vindo(a)!   \n-------------------------");

                Console.WriteLine("\nInforme o total de eleitores");
                totalEleitores = float.Parse(Console.ReadLine());

                Console.WriteLine("\nInforme a quantidade de votos em branco");
                votosEmBranco = float.Parse(Console.ReadLine());

                Console.WriteLine("\nInforme a quantidade de votos nulos");
                votosNulos = float.Parse(Console.ReadLine());

                votosValidos = totalEleitores - (votosEmBranco + votosNulos);

                Console.Clear();

                Console.WriteLine("-------------------------\n        Resultados   \n-------------------------");
                Console.WriteLine("\nVotos nulos.........:" + votosNulos + " | " + ((votosNulos * 100) / totalEleitores).ToString("F") + "%");
                Console.WriteLine("\nVotos em branco.....:" + votosEmBranco + " | " + ((votosEmBranco * 100) / totalEleitores).ToString("F") + "%");
                Console.WriteLine("\nVotos válidos.......:" + votosValidos + " | " + ((votosValidos * 100) / totalEleitores).ToString("F") + "%");
                Console.WriteLine("\nTotal de Eleitores..:" + totalEleitores);

                Console.WriteLine("\n\n Pressione qualquer tecla para encerrar...");
            }
            catch (FormatException) 
            {
                Console.WriteLine("\nInforme um valor numérico");
                Console.WriteLine("\n\n Pressione qualquer tecla para encerrar...");
            }

            Console.ReadKey();
        }
    }
}
