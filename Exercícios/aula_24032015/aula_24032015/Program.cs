using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_24032015
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double num = 0;
            double soma = 0;
            double menor = 0;
            double maior = 0;

            Console.WriteLine("Digite um número.");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite {0} número(s).", n);

            for (int i = 0; i < n; i++)
            {
                num = double.Parse(Console.ReadLine());
                soma = soma + num;
                
                if (num > maior || i == 0)
                {
                    maior = num;
                }

                if (num < menor || i == 0) 
                {
                    menor = num;
                }

            }

            Console.WriteLine("A soma dos números é {0}.", soma);
            Console.WriteLine("O maior número é {0}.", maior);
            Console.WriteLine("O menor número é {0}.", menor);
        }
    }
}
