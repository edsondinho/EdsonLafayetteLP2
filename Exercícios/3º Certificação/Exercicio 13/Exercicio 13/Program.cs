using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Exercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection("Server=localhost;database=test;Uid=root;Pwd=");

            string escolha = "";

            while (escolha.ToLower() != "sair")
            {
                Console.WriteLine("Escreva 'Inserir' para inserir novos dados, 'Consultar' para consultar através do Id ou do Nome, 'Sair' para parar o programa");
                escolha = Console.ReadLine();

                if (escolha.ToLower() == "inserir")
                {
                    Pessoa pes = new Pessoa();
                    pes.Nome = Console.ReadLine();
                    pes.Sobrenome = Console.ReadLine();
                    pes.Peso = double.Parse(Console.ReadLine());
                    pes.Altura = double.Parse(Console.ReadLine());
                    pes.Telefone = Console.ReadLine();
                    cmd.CommandText = String.Format(new CultureInfo("en"), "INSERT INTO PESSOA (NOME, SOBRENOME, PESO, ALTURA, TELEFONE) VALUES ('{0}','{1}',{2},{3},'{4}'",
                        pes.Nome, pes.Sobrenome, pes.Peso, pes.Altura, pes.Telefone);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }

                else if (escolha.ToLower() == "consultar")
                {
                    Console.WriteLine("Consultar por nome ou id?");
                    string esc = Console.ReadLine();
                    MySqlDataReader read = cmd.ExecuteReader();
                    bool consultaValida = false;

                    if (esc.ToLower() == "id")
                    {
                        int id = int.Parse(Console.ReadLine());

                        if (read.HasRows)
                        {
                            while (read.Read())
                            {
                                if (read.GetInt32(0) == id)
                                {
                                    string nome = read.GetString(1);
                                    string sobrenome = read.GetString(2);
                                    double peso = read.GetDouble(3);
                                    double altura = read.GetDouble(4);
                                    string telefone = read.GetString(5);
                                    Console.WriteLine("Id:{0} Nome{1} Sobrenome:{2} Peso:{3} Altura:{4} Telefone:{5}",
                                        id, nome, sobrenome, peso, altura, telefone);
                                    consultaValida = true;
                                }
                            }
                        }

                        if (consultaValida == false)
                        {
                            Console.WriteLine("Consulta sem resultados.");
                        }
                    }

                    else if (esc.ToLower() == "nome")
                    {
                        string nome = Console.ReadLine();
                        int numNomes = 0;

                        if (read.HasRows)
                        {
                            while (read.Read())
                            {
                                if (read.GetString(1) == "nome")
                                {
                                    numNomes++;
                                }
                            }

                            if (numNomes > 0)
                            {
                                int id = int.MinValue;
                                string sobrenome = "";
                                double peso = 0;
                                double altura = 0;
                                string telefone = "";

                                if (numNomes == 1)
                                {
                                    while (read.Read())
                                    {
                                        if (read.GetString(1) == nome)
                                        {
                                            id = read.GetInt32(0); 
                                        }
                                    }
                                }

                                else if (numNomes > 1)
                                {
                                    while (read.Read())
                                    {
                                        if (read.GetString(1) == nome)
                                        {
                                            id = read.GetInt32(0);
                                            sobrenome = read.GetString(2);
                                            Console.WriteLine("Id:{0} Nome:{1} Sobrenome:{2}", id, nome, sobrenome);
                                        }
                                    }
                                    Console.WriteLine("Digite o id do {0} que você quer (Se digitar um id diferente, a consulta não será efetuada com sucesso)", nome);
                                    id = int.Parse(Console.ReadLine());
                                }

                                while (read.HasRows)
                                {
                                    if (read.GetInt32(0) == id && read.GetString(1) == nome)
                                    {
                                        sobrenome = read.GetString(2);
                                        peso = read.GetDouble(3);
                                        altura = read.GetDouble(4);
                                        telefone = read.GetString(5);
                                        Console.WriteLine("Id:{0} Nome{1} Sobrenome:{2} Peso:{3} Altura:{4} Telefone:{5}",
                                            id, nome, sobrenome, peso, altura, telefone);
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("Consulta sem resultados.");
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("Consulta inválida");
                    }

                }
            }
        }
    }
}
