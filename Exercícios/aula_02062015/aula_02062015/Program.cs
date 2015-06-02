using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_02062015
{
    class Program
    {
        static void Main(string[] args)
        {
            string contrario = "";
            string s = Console.ReadLine();

            for (int i = s.Length - 1; i >= 0; i--)
                contrario += s[i].ToString();

            Console.WriteLine(contrario);

            if (contrario == s)
                Console.WriteLine("A palavra é um palíndromo.");

            else
                Console.WriteLine("A palavra não é um palíndromo.");

            //Tentativa de fazer o exercício por conta própria:

            //string frase = "";
            //frase = Console.ReadLine();

            //char [] Frase = new char [frase.Length];
            //char[] Inverso = new char [frase.Length];
            //string inverso = "";

            //for (int i = 0; i < Frase.Length; i++)
            //{
            //    Inverso[i] = Frase[Frase.Length - 1 - i];
            //    inverso += Inverso.ToString();
            //}

            //Console.WriteLine(inverso);

        }
    }
}
