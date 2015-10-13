using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Aula_13._10._15
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection("Server=Localhost;Database=test;Uid=Root;Pwd=");
            while (true)
            {
                string escolha = Console.ReadLine();

                if (escolha.ToLower() == "inserir")
                {
                    Pessoa pes = new Pessoa();
                    pes.Nome = Console.ReadLine();
                    pes.Sobrenome = Console.ReadLine();
                    pes.Peso = double.Parse(Console.ReadLine());
                    pes.Altura = double.Parse(Console.ReadLine());
                    pes.Telefone = Console.ReadLine();
                    cmd.CommandText = String.Format(new CultureInfo("en") ,"INSERT INTO PESSOA (NOME, SOBRENOME, PESO, ALTURA, TELEFONE) VALUES ('{0}','{1}',{2},{3},'{4}'",
                        pes.Nome,pes.Sobrenome, pes.Peso, pes.Altura, pes.Telefone);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
            }
        }
    }
}
