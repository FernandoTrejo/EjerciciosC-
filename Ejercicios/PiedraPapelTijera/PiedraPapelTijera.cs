using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PiedraPapelTijera
{
    internal class PiedraPapelTijera
    {


        //crear un programa que solicite al usuario seleccionar entre piedra, papel o tijera
        //1. piedra
        //2. papel
        //3. tijera

        //calcular aleatoriamente la seleccion de la maquina

        //evaluar las condiciones para verificar quien gana
        //mapas

        /*
         1 => Piedra
            2 => Papel
        3 => tijera
         
         */

        public void Execute()
        {
            string continuar = "si";

            while(continuar == "si")
            {
                Console.WriteLine("Elija una opcion y escriba la palabra");
                Console.WriteLine("piedra, papel, tijera");

                string eleccionUsuario = Console.ReadLine() ?? "";
                Console.WriteLine("La opcion que elegiste es " + eleccionUsuario);

                //codigo para la opcion de la computadora
                int eleccionComputadora = Juego.generarOpcionAleatoria();
                Console.WriteLine("La opcion que eligio la computadora es " + Juego.ObtenerOpcionString(eleccionComputadora));

                string resultado = Juego.VerificarResultado(eleccionComputadora, eleccionUsuario);
                Console.WriteLine(resultado);


                Console.WriteLine("\nDesea seguir jugando? si/no");
                continuar = Console.ReadLine() ?? "si";

            }
            
            
        }
    }
}
