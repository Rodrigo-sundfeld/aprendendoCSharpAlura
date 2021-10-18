using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTrabalhandoComIf
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario < 2600.0)
            {
                Console.WriteLine("A sua aliquota do IR é de 15%");
                Console.WriteLine("Você pode deduzir até R$350,00");
            }

            if (salario < 3750.0)
            {
                Console.WriteLine("A sua aliquota do IR é de 22.5%");
                Console.WriteLine("Você pode deduzir até R$636,00");
            }

            Console.ReadLine();
        }
    }
}
