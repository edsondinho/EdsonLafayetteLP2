using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula23062015
{
    class Funcionario
    {
        public string nome;
        public string cpf;
        public int dataNasc;
        public int dataAdm;
        public double salario;

        public double CalcularAumento()
        {
            double aumento = 0;

            if (dataAdm >= 2014)
            {
                aumento = 423.45;
            }

            else if (dataAdm >= 2010 && dataAdm <= 2013)
            {
                aumento = (salario * 9.84 / 100);
            }

            else if (dataAdm >= 2000 && dataAdm <= 2009)
            {
               aumento = (salario * 16.4 / 100);
            }

            else if (dataAdm <= 1999)
            {
                aumento = (salario * 22.6 / 100);
            }

            return aumento;
        }
    }

}
