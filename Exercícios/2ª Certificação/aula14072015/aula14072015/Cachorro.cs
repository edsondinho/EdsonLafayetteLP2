using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula14072015
{
    class Cachorro
    {
        public double tamanhoCm;
        private string _nome;
        private double _peso;

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetPeso(double peso)
        {
            _peso = peso;
        }

        public double GetPeso()
        {
            return _peso;
        }

        public double RacaoDiariaKg()
        {
            return (_peso/((tamanhoCm/100) *(tamanhoCm/100)))/10;
        }
    }
}
