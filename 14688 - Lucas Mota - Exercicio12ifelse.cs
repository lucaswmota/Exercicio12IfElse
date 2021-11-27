using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe o Nome do Usuario: ");
                string nome = Console.ReadLine().ToUpper();

                Console.Write("Informe a pontuação: ");
                double pontuacao = double.Parse(Console.ReadLine());

                if (pontuacao >= 0)
                {
                    Console.WriteLine("Informe a situação do usuario: " +
                                        "\n(P) Escolaridade Publica;" +
                                        "\n(A) Afrodescendente;" +
                                        "\n(D) Deficiente;" +
                                        "\n(N) Não se enquadra em nenhuma das situações acima.");
                    string situacao = Console.ReadLine().ToUpper();

                    if (situacao == "P")
                    {
                        pontuacao += pontuacao * 0.15;

                        Console.WriteLine("Nome do Candidato: " + nome +
                                            "\nPontuação Final do Candidato: " + pontuacao.ToString("F2"));
                    }
                    else if (situacao == "A")
                    {
                        pontuacao += pontuacao * 0.10;

                        Console.WriteLine("Nome do Candidato: " + nome +
                                            "\nPontuação Final do Candidato: " + pontuacao.ToString("F2"));
                    }
                    else if (situacao == "D")
                    {
                        pontuacao += pontuacao * 0.05;

                        Console.WriteLine("Nome do Candidato: " + nome +
                                            "\nPontuação Final do Candidato: " + pontuacao.ToString("F2"));
                    }
                    else if (situacao == "N")
                    {
                        Console.WriteLine("Nome do Candidato: " + nome +
                                            "\nPontuação Final do Candidato: " + pontuacao.ToString("F2"));
                    }
                    else
                        {
                        Console.WriteLine("Opção Inválida.");
                    }
                }
                else
                {
                    Console.WriteLine("Insira um valor maior do que 0 (Zero)");
                }
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Insira apenas numeros.");
            }
            finally
            {
                Console.WriteLine("Programa encerrado.");
                Console.ReadKey();                
            }
        }
    }
}
