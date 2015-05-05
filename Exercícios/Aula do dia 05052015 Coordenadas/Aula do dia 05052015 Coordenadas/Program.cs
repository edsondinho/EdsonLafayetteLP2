using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_do_dia_05052015_Coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {


            int n  = int.Parse(Console.ReadLine());

            int AreaMaiorVetor = int.MinValue;
            string MaiorVetor = "";
            int Area = int.MinValue;

            int[] x1 = new int[n];
            int[] y1 = new int[n];
            int[] x2 = new int[n];
            int[] y2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite x1[{0}] e y1[{0}]", i);
                x1[i] = int.Parse(Console.ReadLine());
                y1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite x2[{0}] e y2[{0}]", i);
                x2[i] = int.Parse(Console.ReadLine());
                y2[i] = int.Parse(Console.ReadLine());


           }

            for (int i = 0; i < n; i++)
            {
                Area = x1[i] + y1[i];
                if (Area > AreaMaiorVetor)
                {
                    AreaMaiorVetor = Area;
                    MaiorVetor = "x1[" + i + "]  y1[" + i + "] (" + x1[i] + "," + y1[i] + ")";
                }
            }

            for (int i = 0; i < n; i++)
            {
                Area = x2[i] + y2[i];
                if (Area > AreaMaiorVetor)
                {
                    AreaMaiorVetor = Area;
                    MaiorVetor = "x2[" + i + "] y2[" + i + "] (" + x2[i] + "," + y2[i] + ")";
                }
            }

            Console.WriteLine(MaiorVetor);

        }
    }
}
