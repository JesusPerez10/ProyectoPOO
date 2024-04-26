using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO.Clases
{
    internal class Persona
    {
        private string nombre;//Al hacer que los campos sean privados,
                              //se limita el acceso directo a estos campos desde fuera de la clase.
        private int edad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}
