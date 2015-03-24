using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula17032015__com_arraylist_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int soma = 0;
            int media = 0;
            ArrayList num = new ArrayList ();

            Console.WriteLine("Escreva uma quantidade indetermindada de números positivos. (PS: para saber a média, digite o número 0.)");

            while (n != 0)
            {
                n = int.Parse(Console.ReadLine());
                num.Add(n);

                if (n < 0)
                {
                    num.Remove(n);
                    while (n < 0)
                    {
                        Console.WriteLine("Escreva números POSITIVOS.");
                        n = int.Parse(Console.ReadLine());
                    }
                    num.Add(n);
                }

                if (n == 0)
                {
                    num.Remove(n);
                }
            }

            foreach (int numero in num)
            {
                soma = soma + numero;  
            }

            media = soma / num.Count;

            Console.Write("A média dos números ");

            foreach (int numero in num)
            {
                Console.Write("{0} ", numero);
            }

            Console.Write("é igual a {0}. ", media);

        }
    }
}
