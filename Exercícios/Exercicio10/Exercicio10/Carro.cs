using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Carro
    {
        private string _modelo;
        private string _placa;
        private string _marca;
        private int _ano;
        private double _kilometragem;
        private double _capacidadeDoTanque;
        private double _potencia;

        public void SetModelo(string modelo)
        {
            _modelo = modelo;
        }

        public string GetModelo()
        {
            return _modelo;
        }

        public void SetPlaca(string placa) 
        {
            _placa = placa;
        }

        public string GetPlaca()
        {
            return _placa;
        }

        public void SetMarca(string marca)
        {
            _marca = marca;
        }

        public string GetMarca()
        {
            return _marca;
        }

        public void SetAno(int ano)
        {
            _ano = ano;
        }

        public int GetAno()
        {
            return _ano;
        }

        public void SetKilometragem(double kilometragem)
        {
            _kilometragem = kilometragem;
        }

        public double GetKilometragem()
        {
            return _kilometragem;
        }

        public void SetCapacidade(double capacidadeDoTanque) 
        {
            _capacidadeDoTanque = capacidadeDoTanque;
        }

        public double GetCapacidade()
        {
            return _capacidadeDoTanque;
        }

        public void SetPotencia(double potencia)
        {
            _potencia = potencia;
        }

        public double GetPotencia()
        {
            return _potencia;
        }
    }
}
