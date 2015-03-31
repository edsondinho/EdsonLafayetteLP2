using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_310315
{
    class Program
    {
        static void Main(string[] args)
        {

            // Código feito por André e Edson

            int x;
            int y;
            int result = 1;

            Console.Write("Digite seu expoente: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o número da potêntica: ");
            y = int.Parse(Console.ReadLine());

            for (int i = 0; i < y; i++)
            {
                result *= x;
            }

            Console.WriteLine("O resultado é {0}.", result);

        }
    }
}
