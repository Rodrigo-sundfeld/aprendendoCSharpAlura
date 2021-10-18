using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTestaEscopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Testa Escopo.");

            int idade = 20;
            int quantidadePessoas = 1;
            bool acompanhado;


            if (quantidadePessoas >= 2)
            {
                acompanhado = true;
                Console.WriteLine("Você está acompanhado seja bem vindo!");
            }
            else
            {
                acompanhado = false;
                Console.WriteLine("Infelizmente você não pode entrar pois está desacompanhado.");
            }

            if (idade >= 18 && acompanhado)
            {
                Console.WriteLine("Seja bem vindo!");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar.");
            }

            Console.WriteLine("Exercicio finalizado. Pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
