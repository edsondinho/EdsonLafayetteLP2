using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_14042015
{
    class Program
    {
        static void Main(string[] args)
        {

            //Código feito por Edson e Felipe Ribeiro

            string[] participantes = new string[5];             
            double [,] tempo = new double[3 , 5];
            string [] vencedor = new string [3];
            double[] tempovencedor = new double[3];
            double[] tempototal = new double[5];
            double tempocampeao = 0;
            string campeao = "";

            for (int i = 0; i < 5; i++)
            {
                participantes [i] = Console.ReadLine();
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tempo[i, j] = double.Parse(Console.ReadLine());
                }    
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (tempo[i, j] < tempovencedor[i] || (i == 0 && j == 0))
                    {
                        tempovencedor[i] = tempo[i, j];
                        vencedor[i] = participantes[j];
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                tempototal[i] = tempo[0, i] + tempo[1, i] + tempo[2, i];
            }

            for (int i = 0; i < 5; i++)
            {
                if (tempototal[i] < tempocampeao || i == 0)
                {
                    tempocampeao = tempototal[1];
                    campeao = participantes[i];
                }   
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0} ganhou a prova {1}.", vencedor[i], i + 1);
            }

            Console.WriteLine("O campeão é {0}.", campeao);
            Console.WriteLine("Tempo tota {0}s", tempocampeao);

        }
    }
}
