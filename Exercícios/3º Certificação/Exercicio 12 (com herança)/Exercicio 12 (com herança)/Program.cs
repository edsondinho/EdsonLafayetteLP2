using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12__com_herança_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();
            List<Gerente> gerentes = new List<Gerente>();
            List<Terceirizado> terceirizados = new List<Terceirizado>();

            for (int i = 0; i < n; i++)
            {
                string tipoTrabalhador = "";
                while (tipoTrabalhador.ToLower() != "terceirizado" && tipoTrabalhador.ToLower() != "funcionario" && tipoTrabalhador.ToLower() != "gerente")
                {
                    tipoTrabalhador = Console.ReadLine();
                }
                if (tipoTrabalhador.ToLower() != "terceirizado")
                {
                    terceirizados.Add(new Terceirizado());

                    terceirizados[terceirizados.Count - 1].Nome = Console.ReadLine();
                }
                else if (tipoTrabalhador.ToLower() != "funcionario")
                {
                    funcionarios.Add(new Funcionario());
                }
                else
                {
                    gerentes.Add(new Gerente());
                }

            }
        }
    }
}
