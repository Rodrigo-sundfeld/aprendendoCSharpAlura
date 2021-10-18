using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTabuadaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio de tabuada utilizando for.");

            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                Console.WriteLine();

                for (int contador = 0; contador <= 10; contador++)
                {
                    Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Exercicio finalizado pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
