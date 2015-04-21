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
            JogoPinguePongue();
            DesempenhoCarro();
            ConcursoDeBeleza();
            ProvasNatacao();
            SomaNumerosDe1AN();
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

        static void TabelaSalario() //Exercício 3 (Não terminado)
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

                Console.Write("Digite o acréscimo (em porcentagem) do salário do(a) {0}: ", funcionario);
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
                Console.Write("\n\rFuncionário: {0}  Salário Antigo: {1}  Acréscimo: {2}%  Salário Novo: {3} ", funcionario, salario[NumDoFuncionario], acrescimo[NumDoFuncionario], NovoSalario[NumDoFuncionario]);
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

        static void JogoPinguePongue() //Exercício 4
        {
            string jogador1 = "";
            string jogador2 = "";
            int PontosJogador1 = 0;
            int PontosJogador2 = 0;
            string JogadorQueGanhouUmPonto = "";
            bool ContinuarJogo = true;

            Console.Write("Escreva o nome do jogador 1: ");
            jogador1 = Console.ReadLine();

            Console.Write("Escreva o nome do jogador 2: ");
            jogador2 = Console.ReadLine();

            while (ContinuarJogo)
            {
                Console.WriteLine("Qual jogador ganhou um ponto? (Responda com '1' ou '2') ");
                JogadorQueGanhouUmPonto = Console.ReadLine();

                if (JogadorQueGanhouUmPonto == "1" || JogadorQueGanhouUmPonto == "2")
                {
                    if (JogadorQueGanhouUmPonto == "1")
                    {
                        PontosJogador1++;
                        Console.WriteLine("Pontuação do(a) {0}: {1}", jogador1, PontosJogador1);
                        Console.WriteLine("Pontuação do(a) {0}: {1}", jogador2, PontosJogador2);
                    }
                    else
                    {
                        PontosJogador2++;
                        Console.WriteLine("Pontuação do(a) {0}: {1}", jogador1, PontosJogador1);
                        Console.WriteLine("Pontuação do(a) {0}: {1}", jogador2, PontosJogador2);
                    }

                    if ((PontosJogador1 == 21 && PontosJogador1 >= (PontosJogador2 + 2)) || (PontosJogador2 == 21 && PontosJogador2 >= (PontosJogador1 + 2)))
                    {
                        ContinuarJogo = false;
                    }

                    else if ((PontosJogador1 > 21 && PontosJogador1 >= (PontosJogador2 + 2)) || (PontosJogador2 > 21 && PontosJogador2 >= (PontosJogador1 + 2)))
                    {
                        ContinuarJogo = false;
                    }

                }
            }

            if (PontosJogador1 > PontosJogador2)
            {
                Console.WriteLine("{0} ganhou o jogo.", jogador1);
                Console.WriteLine("Pontuação do(a) {0}: {1}", jogador1, PontosJogador1);
                Console.WriteLine("Pontuação do(a) {0}: {1}", jogador2, PontosJogador2);
            }

            else
            {
                Console.WriteLine("{0} ganhou o jogo.", jogador2);
                Console.WriteLine("Pontuação do(a) {0}: {1}", jogador1, PontosJogador1);
                Console.WriteLine("Pontuação do(a) {0}: {1}", jogador2, PontosJogador2);
            }
        }

        static void DesempenhoCarro() //Exercício 5
        {
            int KmPercorridos = 0;
            int LitrosGastos = 0;
            int LitrosTotal = 50;
            double KmPorLitro = 0;
            bool CarroAndando = true;

            while (CarroAndando)
            {
                Console.WriteLine("Acione o aparelho.");
                Console.Write("Informe quantos Quilômetros foram percorridos de acordo com o aparelho: ");
                KmPercorridos += int.Parse(Console.ReadLine());
                Console.Write("Informe quantos Litros foram gastos de acordo com o aparelho: ");
                LitrosGastos += int.Parse(Console.ReadLine());
                LitrosTotal -= LitrosGastos;
                if (KmPercorridos <= 599 || LitrosTotal >= 1)
                {
                    CarroAndando = false;
                }
            }

            if (KmPercorridos >= 600)
            {
                Console.WriteLine("O carro chegou ao seu destino.");
                KmPorLitro = KmPercorridos / LitrosGastos;
                Console.WriteLine("O desempenho médio do carro foi de {0}Km/L.", KmPorLitro);
            }

            else
            {
                Console.WriteLine("Acabou o cosbustível do carro antes dele chagar ao seu destino.");
                KmPorLitro = KmPercorridos / LitrosGastos;
                Console.WriteLine("O desempenho médio do carro foi de {0}Km/L.", KmPorLitro);
            }
        }

        static void ConcursoDeBeleza() //Exercício 6
        {
            ArrayList Participantes = new ArrayList();
            ArrayList Alturas = new ArrayList();
            ArrayList LinhasDeEntrada = new ArrayList();
            int[] MaioresAlturas = new int[2] { 0, 0 };
            int[] ParticipantesComMaioresAlturas = new int[2] { 0, 0 };
            string fim = "";

            while (fim != "FIM")
            {
                Console.Write("Nome da participante: ");
                Participantes.Add(Console.ReadLine());

                fim = Participantes[Participantes.Count - 1].ToString().ToUpper();

                if (fim == "FIM")
                {
                    Participantes.Remove(Participantes[Participantes.Count - 1]);
                }

                else
                {
                    Console.Write("Altura da participante (em centímetros): ");
                    Alturas.Add(int.Parse(Console.ReadLine()));
                }
            }

            foreach (string participante in Participantes)
            {
                LinhasDeEntrada.Add(participante);
            }

            int i = 0;

            foreach (int altura in Alturas)
            {
                LinhasDeEntrada[i] += "  " + altura + "cm";

                if (altura > MaioresAlturas[0])
                {
                    MaioresAlturas[1] = MaioresAlturas[0];
                    ParticipantesComMaioresAlturas[1] = ParticipantesComMaioresAlturas[0];
                    MaioresAlturas[0] = altura;
                    ParticipantesComMaioresAlturas[0] = 1;
                }
                else if (altura == MaioresAlturas[0])
                {
                    ParticipantesComMaioresAlturas[0]++;
                }

                if ((altura > MaioresAlturas[1] && altura != MaioresAlturas[0] || i == 0))
                {
                    MaioresAlturas[1] = altura;
                    ParticipantesComMaioresAlturas[1] = 1;
                }
                else if (altura == MaioresAlturas[1])
                {
                    ParticipantesComMaioresAlturas[1]++;
                }

                i++;
            }

            foreach (string LinhaDeEntrada in LinhasDeEntrada)
            {
                Console.WriteLine("{0}", LinhaDeEntrada);
            }

            Console.WriteLine("A maior altura entres as participantes é {0}cm e {1} participantes possuem essa altura.", MaioresAlturas[0], ParticipantesComMaioresAlturas[0]);
            Console.WriteLine("A segunda maior altura entres as participantes é {0}cm e {1} participantes possuem essa altura.", MaioresAlturas[1], ParticipantesComMaioresAlturas[1]);

        }

        static void ProvasNatacao() //Exercício 7
        {
            int NumeroDaProva = 0;
            int QuantidadeDeNadadores = 0;
            ArrayList nadadores = new ArrayList();
            ArrayList ClacificacaoNadadores = new ArrayList();
            ArrayList TempoDosNadadores = new ArrayList();
            ArrayList ClubeDosNadadores = new ArrayList();
            double[] LugaresTempos = new double[4] { 0, 0, 0, 0 };
            string[] LugaresClubes = new string[4] { "", "", "", "" };
            int[] PontosClubesProvas = new int[2] { 0, 0 };
            int[] PontosClubesCompeticao = new int[2] { 0, 0 };

            while (NumeroDaProva != 9999 || QuantidadeDeNadadores != 0)
            {
                Console.Write("Informe o número da prova: ");
                NumeroDaProva = int.Parse(Console.ReadLine());

                Console.Write("Irforme a quandidade de nadadores que participaram: ");
                QuantidadeDeNadadores = int.Parse(Console.ReadLine());

                if (NumeroDaProva != 9999 || QuantidadeDeNadadores != 0)
                {

                    for (int i = 0; i < QuantidadeDeNadadores; i++)
                    {
                        Console.Write("Informe o nome do {0}° nadador: ", i + 1);
                        nadadores.Add(Console.ReadLine());

                        Console.Write("Informe a classificação dele: ");
                        ClacificacaoNadadores.Add(Console.ReadLine());

                        Console.Write("Informe o tempo que ele levou para concluir a prova (em segundos): ");
                        TempoDosNadadores.Add(double.Parse(Console.ReadLine()));

                        Console.Write("Informe qual o clube que ele participa: ");
                        ClubeDosNadadores.Add(Console.ReadLine().ToUpper());

                    }

                    int I = 0;

                    foreach (double tempo in TempoDosNadadores)
                    {
                        if (tempo < LugaresTempos[0] || I == 0)
                        {
                            LugaresTempos[3] = LugaresTempos[2];
                            LugaresTempos[2] = LugaresTempos[1];
                            LugaresTempos[1] = LugaresTempos[0];
                            LugaresTempos[0] = tempo;

                            LugaresClubes[3] = LugaresClubes[2];
                            LugaresClubes[2] = LugaresClubes[1];
                            LugaresClubes[1] = LugaresClubes[0];
                            LugaresClubes[0] = ClubeDosNadadores[I].ToString();
                        }

                        else if (tempo < LugaresTempos[1] || I == 1)
                        {
                            LugaresTempos[3] = LugaresTempos[2];
                            LugaresTempos[2] = LugaresTempos[1];
                            LugaresTempos[1] = tempo;

                            LugaresClubes[3] = LugaresClubes[2];
                            LugaresClubes[2] = LugaresClubes[1];
                            LugaresClubes[1] = ClubeDosNadadores[I].ToString();
                        }

                        else if (tempo < LugaresTempos[2] || I == 2)
                        {
                            LugaresTempos[3] = LugaresTempos[2];
                            LugaresTempos[2] = tempo;

                            LugaresClubes[3] = LugaresClubes[2];
                            LugaresClubes[2] = ClubeDosNadadores[I].ToString();
                        }

                        else if (tempo < LugaresTempos[3] || I == 3)
                        {
                            LugaresTempos[3] = tempo;

                            LugaresClubes[3] = ClubeDosNadadores[I].ToString();
                        }
                        I++;
                    }

                    I = 0;
                    foreach (string clube in LugaresClubes)
                    {
                        if (clube == "A")
                        {
                            if (I == 0)
                            {
                                PontosClubesProvas[0] += 9;
                                PontosClubesCompeticao[0] += 9;
                            }

                            else if (I == 1)
                            {
                                PontosClubesProvas[0] += 6;
                                PontosClubesCompeticao[0] += 6;
                            }

                            else if (I == 2)
                            {
                                PontosClubesProvas[0] += 4;
                                PontosClubesCompeticao[0] += 4;
                            }

                            else
                            {
                                PontosClubesProvas[0] += 3;
                                PontosClubesCompeticao[0] += 3;
                            }
                        }

                        else if (clube == "B")
                        {
                            if (I == 0)
                            {
                                PontosClubesProvas[1] += 9;
                                PontosClubesCompeticao[1] += 9;
                            }

                            else if (I == 1)
                            {
                                PontosClubesProvas[1] += 6;
                                PontosClubesCompeticao[1] += 6;
                            }

                            else if (I == 2)
                            {
                                PontosClubesProvas[1] += 4;
                                PontosClubesCompeticao[1] += 4;
                            }

                            else
                            {
                                PontosClubesProvas[1] += 3;
                                PontosClubesCompeticao[1] += 3;
                            }
                        }

                        I++;
                    }

                    Console.WriteLine("Na prova {0}, o clube A ganho {1} pontos e o clube B ganhou {2} pontos", NumeroDaProva, PontosClubesProvas[0], PontosClubesProvas[1]);
                }
            }

            if (PontosClubesCompeticao[0] > PontosClubesCompeticao[1])
            {
                Console.WriteLine("O clube A ganhou a competição.");
            }

            else if (PontosClubesCompeticao[1] > PontosClubesCompeticao[0])
            {
                Console.WriteLine("O clube B ganhou a competição.");
            }

            else
            {
                Console.WriteLine("Houve empate.");
            }

        }

        static void SomaNumerosDe1AN() // Exercício 8
        {
            int N = 0;
            int soma = 0;

            Console.Write("Digite um número: ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                soma += i;
            }

            Console.WriteLine("O resultado da soma de todos os números de 1 a {0} é {1}.", N, soma);
        }
    }
}