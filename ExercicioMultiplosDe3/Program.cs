using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio multiplos de 3");
            Console.WriteLine();

            for (int contador = 1; contador < 100; contador++)
            {
                if (contador % 3 == 0)
                {
                    Console.WriteLine(contador);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Exercicio finalizado pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
