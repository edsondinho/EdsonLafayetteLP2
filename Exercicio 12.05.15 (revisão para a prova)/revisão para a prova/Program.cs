using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisão_para_a_prova
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, total = 0;
            Console.WriteLine("m:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("n:");
            n = int.Parse(Console.ReadLine());

            if(m <=100 && n <= 1000)
            {

            int[,] piscina = new int[m, n];
            int[] coluna = new int [m];
            int[] linha = new int [n];

           for (int i = 0; i < m; i++)
           {
               coluna[i] = 0;
           }

            for (int i = 0; i < n; i++)
            {
                linha[i] = 0;
            }
            
                    
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    piscina[i, j] = int.Parse(Console.ReadLine());
                    if (piscina[i, j] == 1)
                    {
                        total++;
                        coluna[i]++;
                        linha[j]++;
                    }
                }
            }

            Console.WriteLine("Total de ajuleijos danificados {0}", total);
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Danificados na coluna {0}: {1}", i + 1 , coluna[i]);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Danificados na linha {0}: {1}", i + 1, linha[i]);
            }

            double reparo, money;
            Console.WriteLine("escreva o valor do reparo:");
            reparo = double.Parse(Console.ReadLine());

            money = total * reparo;
            Console.WriteLine("R${0}", money);
            }

            else { Console.WriteLine("Valores invalidos!!!"); }
        }
    }
}
