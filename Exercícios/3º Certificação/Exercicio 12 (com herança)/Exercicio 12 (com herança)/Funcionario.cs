using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12__com_herança_
{
    class Funcionario: Trabalhador
    {
        public double Salario { get; set; }
        public double ValeAlimentacao()
        {
            double vale = Salario * 0.08;

            if (vale > 750)
            {
                return 750;
            }
                return vale;
        }
    }
}
