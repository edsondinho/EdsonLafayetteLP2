using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace aula22092015
{
    class Program
    {
        static void Main(string[] args)
        {
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";

            MySqlConnection conn = new MySqlConnection(strConn);

            MySqlCommand command = new MySqlCommand();

            string nome = "";
            Console.Write("Nome: ");
            nome = Console.ReadLine();

            command.CommandText = "Insert Into Pessoa (Nome) Values ('" + nome + "')";

            command.Connection = conn;

            conn.Open();

            command.ExecuteNonQuery();

            conn.Close();

        }
    }
}
