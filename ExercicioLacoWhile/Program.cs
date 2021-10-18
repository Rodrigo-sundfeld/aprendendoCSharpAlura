using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLacoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio contador usando while.");
            Console.WriteLine();

            int contador = 0;

            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            Console.WriteLine();
            Console.WriteLine("Exercicio finalizado pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
