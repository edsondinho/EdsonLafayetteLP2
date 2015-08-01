using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int [] idCarro = new int [n + 1];
            string [] modelo = new string [n + 1];
            string [] marca = new string [n + 1];
            string [] placa = new string [n + 1];
            int [] capacidadePassageiros = new int[n + 1];

            int[] passageiros = new int[n + 1];
            for (int i = 1; i <= n; i++)
                passageiros[i] = 0;

            bool[] lotado = new bool[n + 1];

            for (int i = 1; i <= n; i++)
            {
                idCarro[i] = i;
                modelo[i] = Console.ReadLine();
                marca[i] = Console.ReadLine();
                placa[i] = Console.ReadLine();
                capacidadePassageiros[i] = int.Parse(Console.ReadLine());
            }

            int id = 0;
            bool todosCarrosLotados = false;
            int carroLotados = 0;

            while (id != -1 && todosCarrosLotados == false)
            {
                id = int.Parse(Console.ReadLine());

                if (id <= n && id > 0)
                {
                    if (lotado[id] != true)
                    {
                        passageiros[id]++;

                        if (passageiros[id] == capacidadePassageiros[id])
                        {
                            lotado[id] = true;
                            Console.WriteLine("Não há vagas restantes");

                            carroLotados = 0;

                            for (int i = 1; i <= n; i++)
                            {
                                if (lotado[i] == true)
                                    carroLotados++;
                            }

                            if (carroLotados == n)
                                todosCarrosLotados = true;
                        }

                        else
                            Console.WriteLine("Há {0} vaga(s) restante(s)", capacidadePassageiros[id] - passageiros[id]);
                    }

                    else
                    {
                        Console.WriteLine("Carro lotado");

                        carroLotados = 0;

                        for (int i = 1; i <= n; i++)
                        {
                            if (lotado[i] == true)
                                carroLotados++;
                        }

                        if (carroLotados == n)
                            todosCarrosLotados = true;
                    }
                }

                else if (id > n)
                    Console.WriteLine("Carro Inválido");
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\r\nCarro {0}: {1} - {2} ({3})", idCarro[i], modelo[i], marca[i], placa[i]);
                Console.WriteLine("Passageiros: {0}", passageiros[i]);
                if (lotado[i] != true)
                    Console.WriteLine("Vagas restante: {0}", capacidadePassageiros[i] - passageiros[i]);

                else
                    Console.WriteLine("Carro Lotado");
            }

            int totalPessoas = 0;

            for (int i = 1; i <= n; i++)
                totalPessoas += passageiros[i];

            Console.WriteLine("\r\nTotal de pessoas na viagem: {0}", totalPessoas);
        }
    }
}
