using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto da aula 9 - Escopo");

            int idadeRodrigo = 16;
            bool acompanhado = true;
            string mensagemAdicional;
            
            if (acompanhado == true)
            {
                mensagemAdicional = "Rodrigo está acompanhado.";
                Console.WriteLine(mensagemAdicional);   
            }
            else
            {
                mensagemAdicional = "Rodrigo não está acompanhado.";
                Console.WriteLine(mensagemAdicional);
            }

            if (idadeRodrigo >= 18 || acompanhado == true) 
            {
                Console.WriteLine("Rodrigo pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Rodrigo não pode entrar.");

            }

            Console.WriteLine("Execução concluida. Pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}

