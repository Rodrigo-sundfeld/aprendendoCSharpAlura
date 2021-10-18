using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto da aula 8 - Condicionais2");

            int idadeRodrigo = 16;
            //int quantidadePessoas = 2;
            //bool acompanhado = quantidadePessoas >= 2;

            bool acompanhado = true;

            if (idadeRodrigo >= 18 || acompanhado == true)   // || --> operador OU      && --> operador E       == operador igualdade
            {
                Console.WriteLine("Rodrigo pode entrar.");
            }
            else
            {
                Console.WriteLine("Rodrigo não pode entrar.");
                
            }

            Console.WriteLine("Execução concluida. Pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
