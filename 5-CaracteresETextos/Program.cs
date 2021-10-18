using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto da aula 5 - Caracteres e textos.");

            char primeiraLetra = 'R'; //utilizado aspas simples e não dupla
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 2);
            Console.WriteLine(primeiraLetra);

            string titulo = "Rodrigo Sundfeld Batista de Moraes"; //no caso de strings utilizamos aspas duplas
            Console.WriteLine(titulo);

            string titulo2 = "Rodrigo Sundfeld Batista de Moraes " + 1980; //no caso de strings utilizamos aspas duplas
            string cursosProgramacao = " - .NET" +
                "- Java" +
                "- JavaScript";

            string cursosProgramacao2 = 
 @" - .NET
 - Java
 - JavaScript";

            Console.WriteLine(titulo2);
            Console.WriteLine(cursosProgramacao);
            Console.WriteLine();
            Console.WriteLine(cursosProgramacao2);


            string vazia = ""; //string aceitam espaços vazios diferente de char que é necessário declarar um valor (espaço é um valor)
            Console.WriteLine(vazia);

            Console.WriteLine("Execução finalizada. Tecle ENTER para fechar...");
            Console.ReadLine();
        }
    }
}
