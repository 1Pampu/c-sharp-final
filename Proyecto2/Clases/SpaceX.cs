using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Clases
{
    internal abstract class SpaceX
    {
        // Definimos Las variables
        private int anio;
        private int hsActual;
        private string color;
        private string empresa;
        private static int ultimoID = 0;
        public int ID { get; }

        // Declaramos los getters para los atributos
        public int Anio
        {
            get { return anio; }
        }

        public int HsActual
        {
            get { return hsActual; }
        }

        public string Color
        {
            get { return color; }
        }

        public string Empresa
        {
            get { return empresa; }
        }

        // Generamos un constructor
        public SpaceX(int anio, int hsActual, string color, string empresa)
        {
            ID = ultimoID;
            ultimoID++;
            this.anio = anio;
            this.hsActual = hsActual;
            this.color = color;
            this.empresa = empresa;
        }

        // Calculo de cuanta carga tiene el auto y cuantas se le hicieron true = cargaActual false = cargasCompletas
        private string GetCarga(bool cargaActualOcargasCompleta)
        {
            int cargasCompletas = 1;
            int carga = hsActual;
            while (carga > autonomia)
            {
                carga -= autonomia;
                cargasCompletas += 1;
            }
            carga = 100 - ((carga * 100) / autonomia);
            if (cargaActualOcargasCompleta == true) { return $"{carga}%"; }
            if (cargaActualOcargasCompleta == false) { return $"{cargasCompletas}"; }
            return "";
        }

        // Otras cosas necesarias para las clases hijas, metodos, atributos que se sobrescribiran o parecidos
        public int autonomia;
        public int serviceHs;
        public string modelo;

        // Declaramos los getters para los atributos
        public int Autonomia
        {
            get { return autonomia; }
        }

        public int ServiceHs
        {
            get { return serviceHs; }
        }

        public string Modelo
        {
            get { return modelo; }
        }
        public string CargaActual
        {
            get { return GetCarga(true); }
        }

        public string CargasCompletas
        {
            get { return GetCarga(false); }
        }

    }
}
