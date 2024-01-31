using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Clases
{
    internal class Starship : SpaceX
    {
        // Utilizamos el constructor de la clase padre
        public Starship(int anio, int hsActual, string color, string empresa) : base(anio,hsActual,color,empresa) {
            autonomia = 500;
            serviceHs = 1000;
            modelo = "Starship";
        }
    }
}
