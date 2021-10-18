using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto da aula 6 - Atribuições de variáveis");

            int idade = 41;
            int idadeRodrigo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeRodrigo);

            Console.WriteLine("Execução finalizada. Pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
