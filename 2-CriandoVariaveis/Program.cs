using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto da aula 2 - Criando Variáveis");

            int idade;
            idade = 41;

            int idadeNova = 41;

            Console.WriteLine("A minha idade atual é " + idade + " anos.");

            idade = 10;
            Console.WriteLine(idade);
            Console.WriteLine(idadeNova);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.Write(idade);


            Console.WriteLine("Execução finalizada... Tecle ENTER para sair...");
            Console.ReadLine();

        }
    }
}
