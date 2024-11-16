using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Mayor3Numeros
{
    internal class Mayor3Numeros
    {
        //modificadorAcceso (public, private, protected)
        //tipoDatoRetorno (int, String, List<String>, Mayor3Numeros)

        public void Execute() //void -> vacio
        {
            //Crear un programa que evalue el mayor de tres numeros enteros

            //primera parte: la entrada de datos
            //segunda parte: el procesamiento de informacion, o logica
            //tercera parte: el valor que se devuelve, o el resultado

            int numero1 = 0;
            bool esValido = false; // false || true

            while (!esValido) //mientras lo que haya en el parentesis sea true, se ejecuta
            {
                Console.WriteLine("Digite el numero 1: ");
                string input1 = Console.ReadLine();
                esValido = int.TryParse(input1, out numero1);
            }


            //numero1 = Int16.Parse(); //realizar un cast, una conversion de datos

            int numero2 = 0;
            esValido = false;
            while (!esValido)
            {
                Console.WriteLine("Digite el numero 2: ");
                string input2 = Console.ReadLine();
                esValido = int.TryParse(input2, out numero2);
            }


            int numero3 = 0;
            esValido = false;
            while (!esValido)
            {
                Console.WriteLine("Digite el numero 3: ");
                string input3 = Console.ReadLine();
                esValido = int.TryParse(input3, out numero3);
            }

            int numeroMayor = 0;


            if (numero1 >= numero2 && numero1 >= numero3)
            {
                numeroMayor = numero1;
            }

            if (numero2 >= numero1 && numero2 >= numero3)
            {
                numeroMayor = numero2;
            }

            if (numero3 >= numero1 && numero3 >= numero2)
            {
                numeroMayor = numero3;
            }

            Console.WriteLine("El numero mayor es: " + numeroMayor);
        }
    }
}
