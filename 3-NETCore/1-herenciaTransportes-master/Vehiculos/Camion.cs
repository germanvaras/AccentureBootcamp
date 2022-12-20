using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class Camion : Terrestre
    {
         public Camion(string nombre, string modelo, string color, double peso, bool motor, bool carga, int cantPersonas, string tipo, int ruedas, bool puertas, decimal cantidadCarga) : base(nombre, modelo, color, peso, motor, carga, cantPersonas, tipo, ruedas, puertas)
        {
            CantidadCarga = cantidadCarga;
        }
        public decimal CantidadCarga { get; set; }
    }
}
