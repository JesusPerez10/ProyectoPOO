using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoPOO.Clases
{
    delegate void OperacionMatematica(int x,int y);

    class Calculadora
    {
        public void Suma(int x, int y)
        {
            Console.WriteLine("La suma es: " + (x + y));
        }

        public void Resta(int x, int y)
        {
            Console.WriteLine("La resta es: " + (x - y));
        }
    }
}
