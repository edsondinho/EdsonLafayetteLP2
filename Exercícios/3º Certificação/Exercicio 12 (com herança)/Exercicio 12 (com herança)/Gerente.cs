using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12__com_herança_
{
    class Gerente: Trabalhador
    {
        public double Salario { get; set; }
        public string AreaGenciada { get; set; }
        public double Adicional { get; set; }
        public double SalarioTotal()
        {
            return Salario + Adicional;
        }

        public double ValeAlimentacao()
        {
            double vale = SalarioTotal() * 1.065;

            if (vale > 750)
            {
                return 750;
            }

            else
            {
                return vale;
            }
        }
    }
}
