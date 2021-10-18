using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLacoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio de repetição utilizando for");

            for (int contador = 0; contador <= 10; contador ++)
            {
                Console.WriteLine(contador);
            }

            Console.WriteLine("Exercicio finalizado pressione ENTER para sair");
            Console.ReadLine();
        }
    }
}
