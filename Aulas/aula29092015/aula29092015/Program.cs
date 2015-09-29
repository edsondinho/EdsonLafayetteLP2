using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace aula29092015
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha = int.MinValue;

            while(escolha != 0)
            {
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Consulta();
                        break;

                    case 2:
                        Inserir();
                        break;

                    case 3:
                        Remover();
                        break;

                    case 4:
                        Atualizar();
                        break;

                    default:
                        break;
                }
            }
        }

        public static void Consulta()
        {
            Console.WriteLine("Método de Consulta");
            return;
        }
        public static void Inserir()
        {
            Console.WriteLine("Método de Inserir");
            return;
        }
        public static void Remover()
        {
            Console.WriteLine("Método de Remover");
            return;
        }
        public static void Atualizar()
        {
            Console.WriteLine("Método de Atualizar");
            return;
        }

        public static void ConsultaBD()
        {

        }
    }
}