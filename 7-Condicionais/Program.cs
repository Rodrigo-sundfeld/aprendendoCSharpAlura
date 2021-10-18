using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto da aula 7 - Condicionais");

            int idadeRodrigo = 16;
            int quantidadePessoas = 2;

            if (idadeRodrigo >= 18)
            {
                Console.WriteLine("Rodrigo é maior de idade pode entrar.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Rodrigo é menor de idade, porem está acompanhado, pode entrar");
                }
                else
                {
                    Console.WriteLine("Rodrigo é menor de idade não pode entrar.");
                }
            }

            Console.WriteLine("Execução concluida. Pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
