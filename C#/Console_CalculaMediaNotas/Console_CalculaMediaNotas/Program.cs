using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CalculaMediaNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Calcular média das notas de alunos, as notas serão informadas pelo usuário
            // Criação: 18/10/2020

            double nota1, nota2, nota3, resultado;

            try
            {
                Media media = new Media();
                Console.WriteLine("-----------------------\n     Bem-vindo(a)!     \n----------------------- ");
                Console.WriteLine();

                Console.WriteLine("Informe a primeira nota");

                media._nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nInforme a segunda nota");
                media._nota2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nInforme a terceira nota");
                media._nota3 = Convert.ToDouble(Console.ReadLine());

                //Calcula o resultado da media com base nas notas informadas
                resultado = (media._nota1 + media._nota2 + media._nota3) / 3;

                //Limpa o Console
                Console.Clear();

                // Exibe os resultados
                Console.WriteLine("-----------------------\n     Bem-vindo(a)!     \n----------------------- ");
                Console.WriteLine("Média: " + resultado);

                if (resultado < 7)
                {
                    Console.WriteLine("\nVocê foi reprovado.\nProcure o professor para saber a respeito da recuperação.");
                }
                else if (resultado <= 9)
                {
                    Console.WriteLine("\nVocê foi aprovado.\nParabéns.");
                }
                else
                {
                    Console.WriteLine("\nVocê foi aprovado com sucesso! \nParabéns!");
                }
            }
            catch (FormatException)
            {
                /*
                 *  É executada caso o usuário insira um formato de caractere diferente de numérico, que é o aceito pelo tipo de dado double                 
                 */
                Console.Write("Informe apenas dados numéricos para as notas");
            }
            catch (Exception)
            {
                /*
                 * Exceção para caso o usuário informe uma nota menor que zero
                 */
                Console.WriteLine("O valor da nota não pode ser menor que zero!");
            }

            Console.WriteLine("\nPressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
