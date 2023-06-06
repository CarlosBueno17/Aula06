using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Digite de 1 a 10");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 10)
            {
                Console.WriteLine("Digite um número válido");
                return;
            }
            Console.WriteLine("FIM DO PROGRAMA");
            Console.ReadKey();
        }
    }
}
