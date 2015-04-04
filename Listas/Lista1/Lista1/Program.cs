using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            FatorialDeN();
            Exercicio2();
        }

        static void FatorialDeN(int N = -1, bool ex2 = false) 
        {
            int fatorial = 1;

            while (N < 0)
            {
                Console.WriteLine("Escreva um número natural para calcular o seu fatorial.");
                    N = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                fatorial *= (N - i); 
            }

            if (ex2 == true) 
            {
            }

            {
            Console.WriteLine("{0}! = {1}", N, fatorial);
            }
        }

        static void Exercicio2()
        {
            int N = 0;
            int div = 0;
            int divisor = 1;
            double resp = 0; 

            Console.WriteLine("Escreva um número natural.");
            N = int.Parse(Console.ReadLine());

            bool ex2 = true;
            FatorialDeN(N, ex2);

            for (int i = 0; i < N; i++)
            {
                if (div % 2 == 0)
                {
                    resp += fatorial / divisor;

                    if (div == 0)
                    {
                        Console.Write("{0}/{1} ", fatorial, divisor);
                    }
                    else
                    {
                        Console.Write("+ {0}/{1} ", fatorial, divisor);
                    }
                }

                else
                {
                    resp -= fatorial / divisor;
                    Console.Write("- {0}/{1} ", fatorial, divisor);
                }
                div++;
                divisor += (2 * i);
            }

            Console.Write("= {0}", resp);

        }

    }
}
