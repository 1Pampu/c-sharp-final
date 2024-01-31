using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Clases
{
    internal class Cybertruck : Tesla
    {
        // Utilizamos el constructor de la clase padre
        public Cybertruck(int anio, int kmActual, string color, string duenio) : base(anio, kmActual, color, duenio)
        {
            autonomia = 800;
            asientos = 6;
            serviceKm = 3000;
            modelo = "Cybertruck";
        }
    }
}
