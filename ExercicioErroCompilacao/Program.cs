using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioErroCompilacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio erro de compilação");

            int contador = 1;

            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            Console.WriteLine("Exercicio finalizado pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
