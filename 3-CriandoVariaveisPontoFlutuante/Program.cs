using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto da aula 3 - Criando variáveis do tipo ponto flutuante");

            double salario;
            salario = 5000.50;

            Console.WriteLine("O salário do funcionário Rodrigo é de R$" + salario);

            double idade;
            idade = 15 / 2;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("A divisão 5 / 3 usando inteiro é igual  " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("A divisão de 5.0 / 3 usando double é igual " + idade);

            double idadeDouble;
            idadeDouble = 15.0 / 2;
            Console.WriteLine(idadeDouble);

            double idadeDoubleNova;
            idadeDouble = 15 / 2.0;
            Console.WriteLine(idadeDouble);

            Console.WriteLine("Execução finalizada. Tecle ENTER para sair...");
            Console.ReadLine();
        }
    }
}
