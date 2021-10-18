using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLacoAninhadoBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio laço aninhado e break");

            for (int linha = 0; linha <= 10; linha++)
            {
                for (int coluna = 0; coluna <= 10; coluna++)
                {
                    if(coluna >= linha)
                    {
                        break;
                    }
                    Console.Write(coluna+1);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Exercicio finalizado pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
