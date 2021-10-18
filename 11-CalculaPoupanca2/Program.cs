using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto da aula 11 - calcula poupança 2");

            double valorInvestido = 1000;

            for(int contadorMes = 1; contadorMes <= 48; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " mês(es), você terá R$" + valorInvestido);
            }

            Console.WriteLine("Execução finalizada. Pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
