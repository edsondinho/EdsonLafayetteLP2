using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_04082015
{
    class ClienteEstacionamento
    {
        private string _nome;
        private string _cpf;
        private DateTime _dataNascimento;
        private string _placaCarro;
        private double _creditos;

        public string Nome 
        {
            set
            {
                string[] partes = value.Split(' ');
                _nome =  partes[0] + " " + partes[1];
            }

            get
            {
                string[] partes = _nome.Split(' ');
                return partes[1] + ", " + partes[0];
            }

        }


        public string Cpf 
        {
            set 
            {
                _cpf = value;
            }

            get
            {
                string[] partes = new string[4];
                partes[0] = _cpf.Substring(0, 3);
                partes[1] = _cpf.Substring(3, 3);
                partes[2] = _cpf.Substring(6, 3);
                partes[3] = _cpf.Substring(9, 2);
                return partes[0] + partes[1] + partes[2] + partes[3];
            }
        }

        public DateTime DataNascimento 
        {
            set
            {
                string[] partes = value.ToString().Split('/');
                _dataNascimento = new DateTime(int.Parse(partes[2]), int.Parse(partes[1]), int.Parse(partes[0]));
            }

            get
            {
                return _dataNascimento;
            }
        }

        public string PlacaCarro {set; get;}

        public double Creditos {set; get;}

        public void AdicionarCreditos (double creditos)
        {
            _creditos += creditos;
        }

        public void PagarEstacionamento (DateTime hora, double horaAtual, int tempoMinutos)
        {

        }

    }

}

