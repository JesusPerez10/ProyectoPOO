using ProyectoPOO.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO.Claseshijas
{
    internal class Gato:Animal
    {
        public override void Sonido()//se utiliza para indicar que un método
                                     //en una clase derivada está sobrescribiendo (o reemplazando)
                                     //un método de la clase base.
        {
            Console.WriteLine("El gato maulla.");
        }
    }
}
