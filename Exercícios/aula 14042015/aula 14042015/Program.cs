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
            int NumProvas = 0; // 3 = NumProvas
            int NumParticipantes = 0; // 5 = NumParticipantes

            NumProvas = int.Parse(Console.ReadLine());
            NumParticipantes = int.Parse(Console.ReadLine());


            string[] participantes = new string[NumParticipantes];
            double[,] tempo = new double[NumProvas, NumParticipantes];
            string[] vencedor = new string[NumProvas];
            double[] tempovencedor = new double[NumProvas];
            double[] tempototal = new double[NumParticipantes];
            double tempocampeao = 0;
            string campeao = "";

            for (int i = 0; i < NumParticipantes; i++)
            {
                participantes [i] = Console.ReadLine();
            }

            for (int i = 0; i < NumProvas; i++)
            {
                for (int j = 0; j < NumParticipantes; j++)
                {
                    tempo[i, j] = double.Parse(Console.ReadLine());
                }    
            }

            for (int i = 0; i < NumProvas; i++)
            {
                for (int j = 0; j < NumParticipantes; j++)
                {
                    if (tempo[i, j] < tempovencedor[i] || (j == 0))
                    {
                        tempovencedor[i] = tempo[i, j];
                        vencedor[i] = participantes[j];
                    }
                }
            }

            for (int i = 0; i < NumParticipantes; i++)
            {
                tempototal[i] = tempo[0, i] + tempo[1, i] + tempo[2, i];
            }

            for (int i = 0; i < NumParticipantes; i++)
            {
                if (tempototal[i] < tempocampeao || i == 0)
                {
                    tempocampeao = tempototal[i];
                    campeao = participantes[i];
                }   
            }

            for (int i = 0; i < NumProvas; i++)
            {
                Console.WriteLine("{0} ganhou a prova {1}.", vencedor[i], i + 1);
            }

            Console.WriteLine("O campeão é {0}.", campeao);
            Console.WriteLine("Tempo total {0}s", tempocampeao);

        }
    }
}
