using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_do_dia_11082015
{
    class Program
    {
        static void Main(string[] args)
        {
            Eq2Grau eq = new Eq2Grau();

            eq.A = double.Parse(Console.ReadLine());
            eq.B = double.Parse(Console.ReadLine());
            eq.C = double.Parse(Console.ReadLine());

            eq.CalcularX();

            Console.WriteLine("X = {0} ou X = {1}", eq.X1, eq.X2);
        }
    }
}
