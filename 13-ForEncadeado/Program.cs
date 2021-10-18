using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto da aula 13 - for encadeado.");
            Console.WriteLine();


            for (int contadorLinha = 0; contadorLinha <= 100; contadorLinha++)
            {
                for (int contadoColuna = 0; contadoColuna < 100; contadoColuna++)
                {
                    Console.Write("*");
                    if (contadoColuna >= contadorLinha)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

            // Outra forma de realizar o contador

            for (int contadorLinha = 0; contadorLinha <= 100; contadorLinha++)
            {
                for (int contadoColuna = 0; contadoColuna <= contadorLinha; contadoColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Execução finalizada. Pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
