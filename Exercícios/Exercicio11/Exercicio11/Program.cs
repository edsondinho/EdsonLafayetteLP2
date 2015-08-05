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
            List<Carro> carro = new List<Carro>();

            for (int i = 0; i <= n; i++)
            {
                carro.Add(new Carro());
                carro[i].Id = i;
            }

            for (int i = 1; i <= n; i++)
                carro[i].Passageiros = 0;

            for (int i = 1; i <= n; i++)
            {
                carro[i].Id = i;
                carro[i].Modelo = Console.ReadLine();
                carro[i].Marca = Console.ReadLine();
                carro[i].Placa = Console.ReadLine();
                carro[i].CapacidadePassageiros = int.Parse(Console.ReadLine());
            }

            int id = 0;
            bool todosCarrosLotados = false;
            int carrosLotados = 0;

            while (id != -1 && todosCarrosLotados == false)
            {
                id = int.Parse(Console.ReadLine());

                if (id <= n && id > 0)
                {
                    if (carro[id].Lotado != true)
                    {
                        carro[id].Passageiros++;

                        if (carro[id].Passageiros == carro[id].CapacidadePassageiros)
                        {
                            carro[id].Lotado = true;
                            Console.WriteLine("Não há vagas restantes");

                            carrosLotados = 0;

                            for (int i = 1; i <= n; i++)
                            {
                                if (carro[i].Lotado == true)
                                    carrosLotados++;
                            }

                            if (carrosLotados == n)
                                todosCarrosLotados = true;
                        }

                        else
                            Console.WriteLine("Há {0} vaga(s) restante(s)", carro[id].CapacidadePassageiros - carro[id].Passageiros);
                    }

                    else
                    {
                        Console.WriteLine("Carro lotado");

                        carrosLotados = 0;

                        for (int i = 1; i <= n; i++)
                        {
                            if (carro[i].Lotado == true)
                                carrosLotados++;
                        }

                        if (carrosLotados == n)
                            todosCarrosLotados = true;
                    }
                }

                else if (id > n)
                    Console.WriteLine("Carro Inválido");
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\r\nCarro {0}: {1} - {2} ({3})", carro[i].Id, carro[i].Modelo, carro[i].Marca, carro[i].Placa);
                Console.WriteLine("Passageiros: {0}", carro[i].Passageiros);
                if (carro[i].Lotado != true)
                    Console.WriteLine("Vagas restante: {0}", carro[i].CapacidadePassageiros - carro[i].Passageiros);

                else
                    Console.WriteLine("Carro Lotado");
            }

            int totalPessoas = 0;

            for (int i = 1; i <= n; i++)
                totalPessoas += carro[i].Passageiros;

            Console.WriteLine("\r\nTotal de pessoas na viagem: {0}", totalPessoas);
        }
    }
}
