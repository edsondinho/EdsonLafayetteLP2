using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula15092015
{
    class Gerente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public double Salario { get; set; }
        public string Matricula { get; set; }


        public string AreaGenciada { get; set; }
        public double Adicional { get; set; }
        public double SalarioTotal()
        {
            return Salario + Adicional;
        }
    }
}
