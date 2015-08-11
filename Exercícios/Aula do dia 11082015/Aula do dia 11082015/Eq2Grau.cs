using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_do_dia_11082015
{
    class Eq2Grau
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }


        private double Delta;

        public void CalcularDelta()
        {
            Delta = (B * B) - (4 * A * C);
        }

        public double GetDelta()
        {
            return Delta;
        }

        public void CalcularX()
        {
            CalcularDelta();
            X1 = (- B + Math.Sqrt(Delta)) / 2 * A;
            X2 = (-B + Math.Sqrt(Delta)) / 2 * A;
        }
    }
}
