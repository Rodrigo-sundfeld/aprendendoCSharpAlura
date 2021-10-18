using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio de fatoriais");
            Console.WriteLine();

            int fatorial = 1;

            for (int contador = 1; contador <= 10; contador++)
            {
                fatorial *= contador;
                Console.WriteLine("O fatorial de " + contador + " é " + fatorial);
            }

            Console.WriteLine();
            Console.WriteLine("Exercicio finalizado pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
