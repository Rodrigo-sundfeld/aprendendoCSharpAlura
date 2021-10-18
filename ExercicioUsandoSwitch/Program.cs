using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioUsandoSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio utilizando switch");

            int mes = 13;

            switch(mes)
            {
                case 1:
                    Console.WriteLine("O mês escolhido foi Janeiro.");
                    break;

                case 2:
                    Console.WriteLine("O mês escolhido foi Fevereiro.");
                    break;

                case 3:
                    Console.WriteLine("O mês escolhido foi Março.");
                    break;

                case 4:
                    Console.WriteLine("O mês escolhido foi Abril.");
                    break;

                case 5:
                    Console.WriteLine("O mês escolhido foi Maio.");
                    break;

                case 6:
                    Console.WriteLine("O mês escolhido foi Junho.");
                    break;

                case 7:
                    Console.WriteLine("O mês escolhido foi Julho.");
                    break;

                case 8:
                    Console.WriteLine("O mês escolhido foi Agosto.");
                    break;

                case 9:
                    Console.WriteLine("O mês escolhido foi Setembro.");
                    break;

                case 10:
                    Console.WriteLine("O mês escolhido foi Outubro.");
                    break;

                case 11:
                    Console.WriteLine("O mês escolhido foi Novembro.");
                    break;

                case 12:
                    Console.WriteLine("O mês escolhido foi Dezembro.");
                    break;

                default:
                    Console.WriteLine("O mês escolhido é inválido.");
                    break;


            }


            Console.WriteLine("Exercicio finalizado pressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}
