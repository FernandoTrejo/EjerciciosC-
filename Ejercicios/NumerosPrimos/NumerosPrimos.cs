using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.NumerosPrimos
{
    internal class NumerosPrimos
    {
        public void Execute()
        {
            Console.WriteLine("Determinar numeros primos");

            for(int i = 1; i <= 100; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private bool EsPrimo(int numero)
        {
            int cantidadDivisores = 0;
            for(int i = 1; i <= numero; i++)
            {
                if(numero % i == 0)
                {
                    cantidadDivisores = cantidadDivisores + 1;
                }
            }

            return cantidadDivisores == 2;
        }
    }
}
