using ProyectoPOO.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO.Claseshijas
{
    internal class Rectangulo: FiguraGeometrica 
    {
        private double longitud; //Al hacer que los campos sean privados,
                                 //se limita el acceso directo a estos campos desde fuera de la clase.
        private double anchura;

        public Rectangulo(double longitud, double anchura)
        {
            this.longitud = longitud;
            this.anchura = anchura;
        }

        public override double CalcularArea() //se utiliza para indicar que un método
                                              //en una clase derivada está sobrescribiendo (o reemplazando)
                                              //un método de la clase base.
        {
            return longitud * anchura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (longitud + anchura);
        }
    }
}

