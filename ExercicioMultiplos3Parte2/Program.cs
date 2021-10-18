using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMultiplos3Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio para exibir os multiplos de 3 parte 2");
            Console.WriteLine();

            for (int contador = 3; contador < 100; contador += 3)
            {
                Console.WriteLine(contador);
            }

            Console.WriteLine();
            Console.WriteLine("Exercicio finalizado pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
