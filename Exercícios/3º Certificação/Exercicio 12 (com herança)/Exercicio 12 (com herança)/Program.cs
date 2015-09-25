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
                    Console.Write("Informe o tipo de trabalhador: ");
                    tipoTrabalhador = Console.ReadLine();

                    if (tipoTrabalhador.ToLower() == "terceirizado")
                    {
                        terceirizados.Add(new Terceirizado());

                        terceirizados[terceirizados.Count - 1].Nome = Console.ReadLine();
                        terceirizados[terceirizados.Count - 1].CPF = Console.ReadLine();
                        int dia = int.Parse(Console.ReadLine());
                        int mes = int.Parse(Console.ReadLine());
                        int ano = int.Parse(Console.ReadLine());
                        terceirizados[terceirizados.Count - 1].DataDeNascimento = new DateTime(dia, mes, ano);
                        terceirizados[terceirizados.Count - 1].Matricula = Console.ReadLine();
                        terceirizados[terceirizados.Count - 1].CNPJ = Console.ReadLine();
                    }
                    else if (tipoTrabalhador.ToLower() == "funcionario")
                    {
                        funcionarios.Add(new Funcionario());

                        funcionarios[funcionarios.Count - 1].Nome = Console.ReadLine();
                        funcionarios[funcionarios.Count - 1].CPF = Console.ReadLine();
                        int dia = int.Parse(Console.ReadLine());
                        int mes = int.Parse(Console.ReadLine());
                        int ano = int.Parse(Console.ReadLine());
                        funcionarios[funcionarios.Count - 1].DataDeNascimento = new DateTime(dia, mes, ano);
                        funcionarios[funcionarios.Count - 1].Matricula = Console.ReadLine();
                        funcionarios[funcionarios.Count - 1].Salario = double.Parse(Console.ReadLine());
                    }
                    else if (tipoTrabalhador.ToLower() == "gerente")
                    {
                        gerentes.Add(new Gerente());

                        gerentes[gerentes.Count - 1].Nome = Console.ReadLine();
                        gerentes[gerentes.Count - 1].CPF = Console.ReadLine();
                        int dia = int.Parse(Console.ReadLine());
                        int mes = int.Parse(Console.ReadLine());
                        int ano = int.Parse(Console.ReadLine());
                        gerentes[gerentes.Count - 1].DataDeNascimento = new DateTime(dia, mes, ano);
                        gerentes[gerentes.Count - 1].Matricula = Console.ReadLine();
                        gerentes[gerentes.Count - 1].Salario = double.Parse(Console.ReadLine());
                        gerentes[gerentes.Count - 1].Adicional = double.Parse(Console.ReadLine());
                    }
                }
            }
            double folhaDePagamento = 0;

            foreach (Funcionario funcionario in funcionarios)
            {
                folhaDePagamento += funcionario.Salario;
                folhaDePagamento += funcionario.ValeAlimentacao();
            }

            foreach (Gerente gerente in gerentes)
            {
                folhaDePagamento += gerente.SalarioTotal();
                folhaDePagamento += gerente.ValeAlimentacao();
            }
            Console.WriteLine("A folha de pagamento total da empresa é de R${0}", folhaDePagamento);
        }
    }
}
