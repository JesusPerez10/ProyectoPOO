using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO.Clases
{
     class Coleccion
    {
        private string[] elementos = new string[5];

        public string this[int indice]
        {
            get { return elementos[indice]; }
            set { elementos[indice] = value; }
        }
    }
}
