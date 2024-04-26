using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO.Clases
{
    internal class Boton
    {
        public delegate void EventHandler();

        public event EventHandler Click;

        public void OnClick()
        {
            if (Click != null)
                Click();
        }
    }
}
