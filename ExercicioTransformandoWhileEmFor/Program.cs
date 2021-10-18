using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTransformandoWhileEmFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o exercicio de transformar while em for.");

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine(contador);
            }

            Console.WriteLine("Execução finalizada. Pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
