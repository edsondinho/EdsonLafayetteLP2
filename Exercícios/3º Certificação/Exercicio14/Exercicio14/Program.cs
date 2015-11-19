using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection("Server=localhost;database=test;Uid=root;Pwd=");
            MySqlDataReader read = new MySqlDataReader();
            Usuario usu = new Usuario();
            bool logado = false;

            while (true)
            {
                if (logado == false)
                {
                    Console.WriteLine("Tela de Login");
                    Console.Write("Digite seu Login: ");
                    usu.Login = Console.ReadLine();
                    Console.Write("Digite sua senha:");
                    usu.Senha = Console.ReadLine();

                    if (read.HasRows)
                    {
                        while (read.Read() && logado == false)
                        {
                            if (read.GetString(3) == usu.Login && read.GetString(4) == usu.Senha)
                            {
                                DateTime hj = DateTime.Now;
                                cmd.CommandText = String.Format("INSERT INTO USUARIO (UltimoAcesso) VALUES ('{0}')", hj);
                                cmd.Connection.Open();
                                cmd.ExecuteNonQuery();
                                cmd.Connection.Close();
                                logado = true;
                                Console.WriteLine("Login Realizado com sucesso.");
                            }
                        }

                        if (logado == false)
                            Console.WriteLine("Falha no login.");
                    }

                    else
                        Console.WriteLine("Falha no login.");
                }

                else
                {
                    Console.WriteLine("Digite 'sair' para deslogar.");
                    string sair = Console.ReadLine();

                    if (sair.ToLower() == "sair")
                    {
                        logado = false;
                        Console.WriteLine("Você foi deslogado com sucesso.");
                    }
                }
            }

        }
    }
}
