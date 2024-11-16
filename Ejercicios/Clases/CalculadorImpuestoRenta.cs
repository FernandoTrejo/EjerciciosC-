using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clases
{
    internal class CalculadorImpuestoRenta
    {
        public decimal Calcular(decimal cantidadBase)
        {
            //calculos
            decimal baseResultado = this.CalculoEspecifico(cantidadBase); 
            return cantidadBase * 0.10m;
        }

        public decimal CalculoEspecifico(decimal cantidadBase) {
            //serie de calculos
            return cantidadBase;
        }

        public void Calcular2()
        {

        }

        public void Calcular3()
        {

        }

        public void Calc()
        {

        }
    }
}
