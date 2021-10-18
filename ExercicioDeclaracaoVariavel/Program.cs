using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeclaracaoVariavel
{
    class Program
    {
        static void Main(string[] args)
        {
            bool foiPromovido = false;
            double salario;

            if(foiPromovido)
            {
                salario = 4200.0;
            }
            else
            {
                salario = 3800.0;
            }

            Console.WriteLine("O salário é de R$" + salario);
            Console.ReadLine();
        }
    }
}
