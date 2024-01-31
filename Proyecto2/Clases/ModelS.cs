using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Clases
{
    internal class ModelS : Tesla
    {
        // Utilizamos el constructor de la clase padre
        public ModelS(int anio, int kmActual, string color, string duenio) : base(anio, kmActual, color, duenio)
        {
            autonomia = 650;
            asientos = 5;
            serviceKm = 2000;
            modelo = "Model S";
        }
    }
}
