using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2Cert
{
    class Carro
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public int CapacidadePassageiros { get; set; }
        public int Passageiros { get; set; }
        public bool Lotado { get; set; }
        public int Vagas { get; set; }
    }
}
