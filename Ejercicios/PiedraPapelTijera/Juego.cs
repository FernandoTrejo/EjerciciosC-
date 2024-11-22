using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PiedraPapelTijera
{
    internal class Juego
    {
        public static int Piedra = 1;
        public static int Papel = 2;
        public static int Tijera = 3;
        //piedra => tijera
        //papel => piedra
        //tijera => papel
        public static int generarOpcionAleatoria()
        {
            var generadorNumAleatorio = new Random();
            return generadorNumAleatorio.Next(1, 4);
        }

        public static string ObtenerOpcionString(int opcion)
        {
            string opcionString = "";

            if (opcion == Juego.Piedra)
            {
                opcionString = "piedra";
            }
            else if (opcion == Juego.Papel)
            {
                opcionString = "papel";
            }
            else if (opcion == Juego.Tijera)
            {
                opcionString = "tijera";
            }

            return opcionString;
        }

        public static string VerificarResultado(int eleccionComputadora, string eleccionUsuario)
        {
            string resultado = "";
            if (eleccionUsuario == "piedra")
            {

                if (eleccionComputadora == Juego.Piedra)
                {
                    resultado = "Empate";
                }
                else if (eleccionComputadora == Juego.Papel)
                {
                    resultado = "Gana la Computadora";
                }
                else if (eleccionComputadora == Juego.Tijera)
                {
                    resultado = "Ganaste";
                }

            }
            else if (eleccionUsuario == "papel")
            {

                if (eleccionComputadora == Juego.Piedra)
                {
                    resultado = "Ganaste!";
                }
                else if (eleccionComputadora == Juego.Papel)
                {
                    resultado = "Empate";
                }
                else if (eleccionComputadora == Juego.Tijera)
                {
                    resultado = "Gana la computadora";
                }

            }
            else if (eleccionUsuario == "tijera")
            {

                if (eleccionComputadora == Juego.Piedra)
                {
                    resultado = "Gana la computadora";
                }
                else if (eleccionComputadora == Juego.Papel)
                {
                    resultado = "Ganaste";
                }
                else if (eleccionComputadora == Juego.Tijera)
                {
                    resultado = "Lesbianas";
                }

            }

            return resultado;
        }
    }
}
