using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto da aula 4 - Conversões e outros tipos numéricos.");

            double salario;
            salario = 5000.80;

            int salarioInteiro;
            salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);

            int idade; //int comporta 32 bits
            idade = 41;
            Console.WriteLine(idade);

            long idadeLong; //long comporta 64 bits
            idadeLong = 130000000000000000;
            Console.WriteLine(idadeLong);

            short quantidadeProdutos; //short comporta 16 bits
            quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f; //no tipo float é obrigatorio o uso do sufixo f para deixar implicito ao compilador
                                  //forma mais usual é declarar e iniciar a variável na mesma linha;
            Console.WriteLine(altura);

            float altura2 = (float)1.80;
            Console.WriteLine(altura2);

            double valor1 = 0.1;
            double valor2 = 0.2;
            double total = valor1 + valor2;
            Console.WriteLine(total);



            Console.WriteLine("Execução finalizada. Tecle ENTER para sair...");
            Console.ReadLine();
        }
    }
}
