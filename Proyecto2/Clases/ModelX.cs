using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Clases
{
    internal class ModelX : Tesla
    {
        // Utilizamos el constructor de la clase padre
        public ModelX(int anio, int kmActual, string color, string duenio) : base(anio, kmActual, color, duenio)
        {
            autonomia = 560;
            asientos = 7;
            serviceKm = 1000;
            modelo = "Model X";
        }
    }
}
