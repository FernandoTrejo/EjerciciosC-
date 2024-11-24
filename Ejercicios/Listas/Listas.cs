using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Listas
{
    internal class Listas
    {
        public void Execute()
        {
            //arreglos y listas
            //crear una lista de numeros y que el usuario vaya agregando, y al final
            //determinar el promedio,numero mayor, y numero menor

            this.ConLista();

        }

        //listas se dividen pilas (stacks) y colas (queues)
        //las colas, el primero en llegar es el primero en salir
        //las pilas, el ultimo en llegar es el primero en salir

        private void ConLista()
        {
            var lista = new List<int>();

            string continuar = "si";

            int contador = 1;
            while (continuar == "si")
            {
                Console.WriteLine("Ingrese el numero " + contador);
                string input = Console.ReadLine() ?? "0";
                int numero = int.Parse(input);

                lista.Add(numero);

                Console.WriteLine("Desea seguir agregando numeros? si/no");
                continuar = Console.ReadLine() ?? "si";

                contador++; //contador = contador + 1; contador += 1; 
            }

            int numeroMayor = lista.Max();
            int numeroMenor = lista.Min();
            double promedio = lista.Average();
            int total = lista.Sum();

            Console.WriteLine("La cantidad de numeros es de: " + lista.Count);
            Console.WriteLine("El total es de: " + total);
            Console.WriteLine("El promedio es de: " + promedio);

            Console.WriteLine("El numero mayor es: " + numeroMayor);

            Console.WriteLine("El numero menor es: " + numeroMenor);
        }

        private void ConArreglo()
        {
            int[] arreglo = new int[10];
            //0, 1, 2 ... 9
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el numero " + (i + 1));
                string input = Console.ReadLine() ?? "0";
                int numero = Convert.ToInt32(input);  //alternativa: int.Parse(input); 
                arreglo[i] = numero;
            }

            //extraer numero mayor y menor
            //10, 98, 45,  12
            int numeroMayor = arreglo[0];
            int numeroMenor = arreglo[0];
            decimal promedio = 0;
            decimal total = 0;

            for (int i = 0; i < 10; i++)
            {
                int valorPosicion = arreglo[i];

                if (valorPosicion > numeroMayor)
                {
                    numeroMayor = valorPosicion;
                }

                if (valorPosicion < numeroMenor)
                {
                    numeroMenor = valorPosicion;
                }

                total += valorPosicion;// es lo mismo que: total = total + valorPosicion;
            }

            promedio = total / arreglo.Length;
            Console.WriteLine("La cantidad de numeros es de: " + arreglo.Length);
            Console.WriteLine("El total es de: " + total);
            Console.WriteLine("El promedio es de: " + promedio);

            Console.WriteLine("El numero mayor es: " + numeroMayor);

            Console.WriteLine("El numero menor es: " + numeroMenor);
        }
    }
}
