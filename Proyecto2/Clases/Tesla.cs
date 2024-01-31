using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Clases
{
    // Definimos una Clase Padre Tesla
    internal abstract class Tesla
    {
        // Definimos Las variables
        private int anio;
        private int kmActual;
        private string color;
        private string duenio;
        private static int ultimoID = 0;
        public int ID { get; }
        

        // Declaramos los getters para los atributos
        public int Anio
        {
            get { return anio; }
        }

        public int KmActual
        {
            get { return kmActual; }
        }

        public string Color
        {
            get { return color; }
        }

        public string Duenio 
        {
            get { return duenio; } 
        }
        // Generamos un constructor
        public Tesla(int anio, int kmActual, string color, string duenio)
        {
            ID = ultimoID;
            ultimoID++;
            this.anio = anio;
            this.kmActual = kmActual;
            this.color = color;
            this.duenio = duenio;
        }

        // Calculo de cuanta carga tiene el auto y cuantas se le hicieron true = cargaActual false = cargasCompletas
        private string GetCarga(bool cargaActualOcargasCompleta)
        {
            int cargasCompletas = 1;
            int carga = KmActual;
            while (carga > autonomia)
            {
                carga -= autonomia;
                cargasCompletas += 1;
            }
            carga = 100 - ((carga * 100) / autonomia);
            if (cargaActualOcargasCompleta == true) { return $"{carga}%"; }
            if (cargaActualOcargasCompleta == false) {return $"{cargasCompletas}"; }
            return "";
        }

        // Otras cosas necesarias para las clases hijas, metodos, atributos que se sobrescribiran o parecidos
        public int autonomia;
        public int asientos;
        public int serviceKm;
        public string modelo;

        // Declaramos los getters para los atributos
        public int Autonomia
        {
            get { return autonomia; }
        }

        public int Asientos
        {
            get { return asientos; }
        }

        public int ServiceKm
        {
            get { return serviceKm; }
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
            get { return GetCarga(false);}
        }
      
    }
}

