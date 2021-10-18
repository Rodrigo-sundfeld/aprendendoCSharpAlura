using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEhIdoso
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 68;
            bool ehIdoso = idade >= 65;

            Console.WriteLine(ehIdoso);
            Console.ReadLine();
        }
    }
}
