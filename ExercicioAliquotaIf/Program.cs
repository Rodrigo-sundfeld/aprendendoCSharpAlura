using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAliquotaIf
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 4664.1;

            Console.WriteLine("Exercicio Aliquota IR utilizando Ifs.");

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("A sua aliquota do IR é de 7.5%");
                Console.WriteLine("Você pode deduzir até R$142,00");
            }

            else if (salario >= 2800.1 && salario <= 3751.0)
            {
                Console.WriteLine("A sua aliquota do IR é de 15%");
                Console.WriteLine("Você pode deduzir até R$350.00");
            }

            else if (salario >= 3751.1 && salario <= 4664.0)
            {
                Console.WriteLine("A sua aliquota do IR é de 22.5%");
                Console.WriteLine("Você pode deduzir até R$636,00");
            }

            else
            {
                Console.WriteLine("A sua aliquota do IR é de 27.5%");
                Console.WriteLine("Você pode deduzir até R$869,00");
            }

            Console.WriteLine("Fim do exercicio pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
