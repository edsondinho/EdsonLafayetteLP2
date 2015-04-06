using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            FatorialDeN();
            Exercicio2();
            TabelaSalario();
        }

        static void FatorialDeN(int N = -1, bool ex2 = false) //Exercício 1
        {
            int fatorial = 1;

            while (N < 0)
            {
                Console.WriteLine("Escreva um número natural para calcular o seu fatorial.");
                    N = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                fatorial *= (N - i); 
            }

            if (ex2 == true) 
            {
            }

            {
            Console.WriteLine("{0}! = {1}", N, fatorial);
            }
        }

        static void Exercicio2()
        {
            int N = 0;
            int div = 0;
            int divisor = 1;
            double resp = 0; 

            Console.WriteLine("Escreva um número natural.");
            N = int.Parse(Console.ReadLine());

            bool ex2 = true;
            FatorialDeN(N, ex2);

            for (int i = 0; i < N; i++)
            {
                if (div % 2 == 0)
                {
                    resp += fatorial / divisor;

                    if (div == 0)
                    {
                        Console.Write("{0}/{1} ", fatorial, divisor);
                    }
                    else
                    {
                        Console.Write("+ {0}/{1} ", fatorial, divisor);
                    }
                }

                else
                {
                    resp -= fatorial / divisor;
                    Console.Write("- {0}/{1} ", fatorial, divisor);
                }
                div++;
                divisor += (2 * i);
            }

            Console.Write("= {0}", resp);

        }

        static void TabelaSalario() //Exercício 3
        {
            ArrayList funcionarios = new ArrayList();
            int NumFuncionarios = 0;

            while (NumFuncionarios <= 0)
            {
                Console.Write("Digite a quantidade de funcionários: ");
                NumFuncionarios = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Escreva os nomes dos {0} funcionários", NumFuncionarios);

            for (int i = 0; i < NumFuncionarios; i++)
            {
                funcionarios.Add(Console.ReadLine().ToString());
            }

            double[] salario = new double[(funcionarios.Count)];
            double[] acrescimo = new double[(funcionarios.Count)];
            int NumDoFuncionario = 0;

            foreach (string funcionario in funcionarios)
            {
                Console.Write("Digite o salário do(a) {0}: ", funcionario);
                salario[NumDoFuncionario] = double.Parse(Console.ReadLine());

                Console.Write("Digite o acréscimo (em porcentagem) do salário do(a) {0}", funcionario);
                acrescimo[NumDoFuncionario] = double.Parse(Console.ReadLine());

                NumDoFuncionario++;
            }

            double[] NovoSalario = new double[(funcionarios.Count)];

            for (int i = 0; i < funcionarios.Count; i++)
            {
                NovoSalario[i] = salario[i] + (salario[i] * acrescimo[i]) / 100;
            }

            NumDoFuncionario = 0;

            foreach (string funcionario in funcionarios)
            {
                Console.WriteLine("Funcionário: {0}  Salário Antigo: {1}  Acréscimo: {2}%  Salário Novo: {3}", funcionario, salario[NumDoFuncionario], acrescimo[NumDoFuncionario], NovoSalario[NumDoFuncionario]);
                NumDoFuncionario++;
            }

            int SalariosEntre0E2999 = 0;
            int SalariosEntre3000E3999 = 0;
            int SalariosEntre4000E4999 = 0;
            int SalariosDe5000OuMais = 0;
            int NovosSalariosEntre0E2999 = 0;
            int NovosSalariosEntre3000E3999 = 0;
            int NovosSalariosEntre4000E4999 = 0;
            int NovosSalariosDe5000OuMais = 0;

            for (int i = 0; i < funcionarios.Count; i++)
            {
                if (salario[i] >= 0 && salario[i] <= 2999)
                {
                    SalariosEntre0E2999++;
                }

                else if (salario[i] >= 3000 && salario[i] <= 3999)
                {
                    SalariosEntre3000E3999++;
                }

                else if (salario[i] >= 4000 && salario[i] <= 4999)
                {
                    SalariosEntre4000E4999++;
                }

                else if (salario[i] >= 5000)
                {
                    SalariosEntre4000E4999++;
                }

                if (NovoSalario[i] >= 0 && NovoSalario[i] <= 2999 && (salario[i] < 0 || salario[i] > 2999))
                {
                    NovosSalariosEntre0E2999++;
                }

                else if (NovoSalario[i] >= 3000 && NovoSalario[i] <= 3999 && (salario[i] < 3000 || salario[i] > 3999))
                {
                    NovosSalariosEntre3000E3999++;
                }

                else if (NovoSalario[i] >= 4000 && NovoSalario[i] <= 4999 && (salario[i] < 4000 || salario[i] > 4999))
                {
                    NovosSalariosEntre4000E4999++;
                }

                else if (NovoSalario[i] >= 5000 && salario[i] < 5000)
                {
                    NovosSalariosDe5000OuMais++;
                }

            }

        }

    }
}
