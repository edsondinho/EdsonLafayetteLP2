using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula23062015
{
    class Program
    {
        static void Main(string[] args)
        {
            // Versão sem a classe Funcionario:

            //  int NumFuncionarios = int.Parse(Console.ReadLine());

            //string[] cpf = new string[NumFuncionarios];
            //string[] nome = new string[NumFuncionarios];
            //int[] DataNasc = new int[NumFuncionarios];
            //int[] DataAdm = new int[NumFuncionarios];
            //double[] salario = new double[NumFuncionarios];
            //double[] NovoSalario = new double[NumFuncionarios];

            //for (int i = 0; i < NumFuncionarios; i++)
            //{
            //    cpf[i] = Console.ReadLine();
            //    nome[i] = Console.ReadLine();
            //    DataNasc[i] = int.Parse(Console.ReadLine());
            //    DataAdm[i] = int.Parse(Console.ReadLine());
            //    salario[i] = double.Parse(Console.ReadLine());

            //    if (DataAdm[i] >= 2014)
            //    {
            //        NovoSalario[i] = salario[i] + 423.45;
            //    }

            //    else if (DataAdm[i] >= 2010 && DataAdm[i] <= 2013)
            //    {
            //        NovoSalario[i] = salario[i] + (salario[i] * 9.84 / 100);
            //    }

            //    else if (DataAdm[i] >= 2000 && DataAdm[i] <= 2009)
            //    {
            //        NovoSalario[i] = salario[i] + (salario[i] * 16.4 / 100);
            //    }

            //    else if (DataAdm[i] <= 1999)
            //    {
            //        NovoSalario[i] = salario[i] + (salario[i] * 22.6 / 100);
            //    }
            //}

            //for (int i = 0; i < NumFuncionarios; i++)
            //{
            //Console.WriteLine("CPF: " + cpf[i]);
            //Console.WriteLine("Nome: " + nome[i]);
            //Console.WriteLine("Nasc: " + DataNasc[i]);
            //Console.WriteLine("Admis: " + DataAdm[i]);
            //Console.WriteLine("Salário Atual: " + salario[i]);
            //Console.WriteLine("Novo Salário: " + NovoSalario[i]);
            //}

            // Versão com a classe Funcionario

            int NumFuncionarios = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumFuncionarios; i++)
            {
                Funcionario funcionario = new Funcionario();

                funcionario.cpf = Console.ReadLine();
                funcionario.nome = Console.ReadLine();
                int dia = int.Parse(Console.ReadLine());
                int mes = int.Parse(Console.ReadLine());
                int ano = int.Parse(Console.ReadLine());
                funcionario.dataNasc = new DateTime(ano, mes, dia);
                dia = int.Parse(Console.ReadLine());
                mes = int.Parse(Console.ReadLine());
                ano = int.Parse(Console.ReadLine());
                funcionario.dataAdm = new DateTime(ano, mes, dia);
                funcionario.salario = double.Parse(Console.ReadLine());
                double salarioNovo = funcionario.salario + funcionario.CalcularAumento();

                Console.WriteLine("CPF: " + funcionario.cpf);
                Console.WriteLine("Nome: " + funcionario.nome);
                Console.WriteLine("Nasc: " + funcionario.dataNasc.Date.ToString());
                Console.WriteLine("Admis: " + funcionario.dataAdm.Date.ToString());
                Console.WriteLine("Salário Atual: " + funcionario.salario);
                Console.WriteLine("Novo Salário: " + salarioNovo);
            }
        }
    }
}
