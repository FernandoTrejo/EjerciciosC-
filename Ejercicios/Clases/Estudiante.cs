﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clases
{
    internal class Estudiante
    {
        private string nombre;
        private string apellido;
        private int edad;

        public string getNombre()
        {
            return nombre;
        }

        public string getApellido()
        {
            return apellido;
        }

        public int getEdad()
        {
            return edad;
        }
    }
}