using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Clases
{
    internal class Falcon9 : SpaceX
    {
        // Utilizamos el constructor de la clase padre
        public Falcon9(int anio, int hsActual, string color, string empresa) : base(anio, hsActual, color, empresa)
        {
            autonomia = 200;
            serviceHs = 400;
            modelo = "Falcon 9";
        }
    }
}
